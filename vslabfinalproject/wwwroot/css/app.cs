:root{
    --bg:#f3f7ff;
    --surface:#ffffff;
    --surface - 2:#f8fbff;
    --border:#e8eef9;
    --text:#14213d;
    --muted:#6b7a90;
    --primary:#4f46e5;
    --primary - 2:#2563eb;
    --accent:#06b6d4;
    --success:#10b981;
    --warning:#f59e0b;
    --danger:#ef4444;
    --shadow:0 18px 45px rgba(37, 99, 235, 0.08);
--shadow - soft:0 10px 30px rgba(15, 23, 42, 0.06);
}

html, body{min-height:100 %; background: radial - gradient(circle at top left,#eef4ff 0%,#f7f9fc 45%,#f4f7fb 100%);color:var(--text)}
body{ font - family:Inter,"Segoe UI",Tahoma,Geneva,Verdana,sans - serif}
a{transition:all .2s ease}

.app - shell{ display: flex; min - height:100vh; position: relative}
.sidebar{width:290px; background: linear - gradient(180deg,#0f172a 0%,#111827 55%,#172554 100%);color:#fff;padding:1.35rem;position:sticky;top:0;height:100vh;box-shadow:30px 0 60px rgba(15,23,42,.12);overflow-y:auto}
.brand{ display: flex; gap: .9rem; align - items:center; margin - bottom:1.5rem}
.brand - icon{
width: 52px; height: 52px; border - radius:18px; background: linear - gradient(135deg,#4f46e5,#06b6d4);display:grid;place-items:center;font-weight:800;font-size:1rem;box-shadow:0 12px 30px rgba(79,70,229,.35)}
.brand strong{ font - size:1.1rem; display: block}
.brand small{
    display: block; color:#cbd5e1}
.sidebar - section - title{
            font - size:.72rem; text - transform:uppercase; letter - spacing:.08em; color:#93c5fd;margin:1.2rem 0 .7rem .2rem;font-weight:800}
.nav - list{ display: grid; gap: .45rem}
.nav - list a{
            display: flex; align - items:center; gap: .7rem; color:#dbeafe;text-decoration:none;padding:.82rem .9rem;border-radius:1rem;font-weight:600;background:rgba(255,255,255,.02);border:1px solid transparent}
.nav - list a: hover,.nav - list a.active{
                background: linear - gradient(135deg, rgba(79, 70, 229, .9), rgba(37, 99, 235, .9)); color:#fff;border-color:rgba(255,255,255,.1);transform:translateX(2px);box-shadow:0 12px 24px rgba(37,99,235,.22)}
.nav - icon{ width: 1.4rem; text - align:center; opacity: .95}
.sidebar - user,.sidebar - tip{ background: rgba(255, 255, 255, .06); border: 1px solid rgba(255, 255, 255, .08); border - radius:1.15rem; padding: 1rem; margin - top:1.1rem; backdrop - filter:blur(8px)}
.sidebar - user{ display: flex; align - items:center; gap: .9rem}
.avatar - badge{
                    width: 44px; height: 44px; border - radius:14px; background: linear - gradient(135deg,#60a5fa,#818cf8);display:grid;place-items:center;font-weight:800;color:#fff;flex-shrink:0}
.sidebar - user strong,.sidebar - tip strong{ display: block}
.sidebar - user small,.sidebar - tip small{
                        color:#cbd5e1;display:block}
.sidebar - tip ul{
                            margin: 0; padding - left:1rem; color:#dbeafe;font-size:.92rem}
.logout - btn{ border - radius:.95rem; font - weight:700; padding: .8rem 1rem}

.main - content{ flex: 1; min - width:0; padding: 1.15rem}
.topbar{ background: rgba(255, 255, 255, .76); backdrop - filter:blur(10px); padding: 1.25rem 1.5rem; border: 1px solid rgba(255, 255, 255, .8); border - radius:1.5rem; box - shadow:var(--shadow - soft); display: flex; justify - content:space - between; gap: 1rem; align - items:center}
.topbar.eyebrow{
                                display: inline - flex; padding: .4rem .75rem; border - radius:999px; background:#eef2ff;color:#4338ca;font-size:.78rem;font-weight:800;letter-spacing:.02em;margin-bottom:.55rem}
.topbar h1{
                                        font - size:1.8rem; margin: 0 0 .2rem; font - weight:800; color:#0f172a}
.topbar p{ margin: 0; color: var(--muted); max - width:760px}
.topbar - actions{ display: flex; gap: .75rem; flex - wrap:wrap; justify - content:flex - end}
.mini - badge{
                                        display: inline - flex; align - items:center; gap: .4rem; background: var(--surface); border: 1px solid var(--border); padding: .7rem .95rem; border - radius:999px; color:#334155;font-weight:700;box-shadow:var(--shadow-soft)}
.mini - badge.primary{
                                            background: linear - gradient(135deg,#4f46e5,#2563eb);color:#fff;border:none}

.page - container{ padding: 1.25rem .2rem 0}
.page - title{ display: flex; justify - content:space - between; gap: 1rem; align - items:center; margin - bottom:1.1rem}
.page - title h2{
                                                margin: 0 0 .25rem; font - weight:800; color:#0f172a}
.page - title p{ margin: 0; color: var(--muted)}
.grid{ display: grid; gap: 1rem}
.grid - 4{ grid - template - columns:repeat(4, minmax(0, 1fr))}
.grid - 3{ grid - template - columns:repeat(3, minmax(0, 1fr))}
.grid - 2{ grid - template - columns:repeat(2, minmax(0, 1fr))}

.dashboard - hero{
                                                    background: linear - gradient(135deg,#1d4ed8 0%,#4f46e5 45%,#0891b2 100%);border-radius:1.7rem;padding:1.7rem;color:#fff;box-shadow:0 24px 60px rgba(37,99,235,.22);position:relative;overflow:hidden}
.dashboard - hero::before,.dashboard - hero::after{ content: ""; position: absolute; border - radius:50 %; background: rgba(255, 255, 255, .12)}
.dashboard - hero::before{ width: 260px; height: 260px; right: -70px; top: -90px}
.dashboard - hero::after{ width: 180px; height: 180px; left: -50px; bottom: -80px}
.hero - content{ position: relative; z - index:1}
.dashboard - hero h2{ font - size:2rem; font - weight:800; margin - bottom:.45rem}
.dashboard - hero p{ max - width:700px; color: rgba(255, 255, 255, .92); margin - bottom:1rem}
.metric - chips{ display: flex; gap: .75rem; flex - wrap:wrap}
.metric - chip{ background: rgba(255, 255, 255, .14); border: 1px solid rgba(255, 255, 255, .12); border - radius:1rem; padding: .85rem 1rem; min - width:150px}
.metric - chip span{ display: block; font - size:.82rem; color: rgba(255, 255, 255, .82)}
.metric - chip strong{ display: block; font - size:1.15rem; margin - top:.2rem}

.stat - card{
                                                        background: linear - gradient(180deg,#ffffff 0%,#f8fbff 100%);border-radius:1.35rem;padding:1.15rem;box-shadow:var(--shadow);border:1px solid var(--border);transition:transform .2s ease, box-shadow .2s ease;position:relative;overflow:hidden}
.stat - card:hover,.data - card:hover{ transform: translateY(-3px); box - shadow:0 25px 50px rgba(15,23,42,.10)}
.stat - card::after{ content: ""; position: absolute; inset: auto - 20px - 38px auto; width: 120px; height: 120px; border - radius:50 %; background: rgba(79, 70, 229, .06)}
.stat - top{ display: flex; justify - content:space - between; gap: 1rem; align - items:flex - start; position: relative; z - index:1}
.stat - card span{ display: block; color: var(--muted); font - weight:700; font - size:.9rem}
.stat - card strong{
                                                            display: block; font - size:2rem; margin: .25rem 0; color:#0f172a;line-height:1.1}
.stat - card small{ color: var(--muted); display: block; position: relative; z - index:1}
.stat - icon{
                                                                width: 46px; height: 46px; border - radius:15px; display: grid; place - items:center; font - size:1.2rem; font - weight:700; background:#eef2ff;color:#4338ca;box-shadow:inset 0 0 0 1px rgba(79,70,229,.07)}
.stat - card.primary.stat - icon{
                                                                    background:#eef2ff;color:#4338ca}
.stat - card.success.stat - icon{
                                                                        background:#ecfdf5;color:#059669}
.stat - card.warning.stat - icon{
                                                                            background:#fff7ed;color:#d97706}
.stat - card.info.stat - icon{
                                                                                background:#ecfeff;color:#0891b2}

.data - card{ background: rgba(255, 255, 255, .88); border - radius:1.35rem; padding: 1.15rem; box - shadow:var(--shadow - soft); border: 1px solid var(--border); margin - bottom:1rem; transition: transform .2s ease, box-shadow .2s ease}
.card - heading{ display: flex; justify - content:space - between; align - items:center; gap: 1rem; margin - bottom:.85rem}
.card - heading h3{
                                                                                    margin: 0; font - size:1.08rem; font - weight:800; color:#0f172a}
.card - heading p{ margin: 0; color: var(--muted); font - size:.92rem}
.card - subtle{ font - size:.86rem; color: var(--muted); font - weight:600}

.toolbar{ display: flex; gap: .75rem; align - items:center; flex - wrap:wrap}
.form - grid{ display: grid; grid - template - columns:repeat(3, minmax(0, 1fr)); gap: 1rem}
.form - grid - full{ grid - column:1 / -1}
.compact - actions{ gap: .35rem}
.form - label{
                                                                                            font - weight:700; color:#334155;margin-bottom:.4rem}
.form - control,.form - select{
                                                                                                border - radius:.95rem; padding: .8rem .95rem; border: 1px solid #dbe5f3;background:#fbfdff;box-shadow:none}
.form - control:focus,.form - select:focus{
                                                                                                    border - color:#93c5fd;box-shadow:0 0 0 .25rem rgba(59,130,246,.12);background:#fff}
.btn{ border - radius:.95rem; font - weight:700; padding: .75rem 1rem}
.btn - sm{ border - radius:.8rem; padding: .45rem .75rem}
.btn - primary{
                                                                                                    background: linear - gradient(135deg,#4f46e5,#2563eb);border:none;box-shadow:0 12px 24px rgba(79,70,229,.22)}
.btn - primary:hover{ filter: brightness(.98); transform: translateY(-1px)}
.btn - secondary{
                                                                                                        background:#e2e8f0;color:#0f172a;border:none}
.btn - outline - secondary{
                                                                                                            background:#fff;color:#475569;border:1px solid #cbd5e1}
.btn - danger{
                                                                                                                background: linear - gradient(135deg,#ef4444,#dc2626);border:none}
.btn - outline - light{ border - color:rgba(255, 255, 255, .22)}
.validation - message,.validation - message *{
                                                                                                                    color:#dc2626;font-size:.85rem}

.table - wrap{ overflow - x:auto; border - radius:1rem}
.table{ margin - bottom:0; vertical - align:middle}
.table thead th{
                                                                                                                        background:#f8fbff;color:#475569;border-bottom-color:#e2e8f0;font-size:.9rem;font-weight:800;text-transform:uppercase;letter-spacing:.03em;padding:.95rem .85rem}
.table tbody td{
                                                                                                                            padding: .95rem .85rem; border - color:#eef2f7}
.table tbody tr: nth - child(even){
                                                                                                                                background:#fcfdff}
.table tbody tr:hover{
                                                                                                                                    background:#f6f9ff}
.status - pill{
                                                                                                                                        display: inline - flex; align - items:center; border - radius:999px; padding: .36rem .72rem; background:#e0f2fe;color:#075985;font-weight:800;font-size:.82rem;border:1px solid #bae6fd}
.status - pill.success{
                                                                                                                                            background:#dcfce7;color:#166534;border-color:#bbf7d0}
.status - pill.warning{
                                                                                                                                                background:#fef3c7;color:#92400e;border-color:#fde68a}
.status - pill.danger{
                                                                                                                                                    background:#fee2e2;color:#991b1b;border-color:#fecaca}
.status - pill.info{
                                                                                                                                                        background:#e0f2fe;color:#075985;border-color:#bae6fd}
.badge - soft{
                                                                                                                                                            display: inline - flex; align - items:center; border - radius:999px; background:#eef2ff;color:#4338ca;padding:.35rem .7rem;font-size:.8rem;font-weight:800}

.progress - modern{
                                                                                                                                                                height: .7rem; background:#e2e8f0;border-radius:999px;overflow:hidden}
.progress - modern > span{
                                                                                                                                                                    display: block; height: 100 %; border - radius:999px; background: linear - gradient(90deg,#4f46e5,#06b6d4)}
.list - clean{ margin: 0; padding: 0; list - style:none}
.list - clean li{
                                                                                                                                                                        display: flex; justify - content:space - between; gap: 1rem; padding: .85rem 0; border - bottom:1px solid #edf2f7}
.list - clean li: last - child{ border - bottom:none; padding - bottom:0}
.item - title{
                                                                                                                                                                                font - weight:700; color:#0f172a}
.item - text{ font - size:.92rem; color: var(--muted)}
.item - meta{ font - size:.82rem; color: var(--muted); text - align:right; white - space:nowrap}
.empty - state{ padding: 2rem 1rem; text - align:center; color: var(--muted)}
.quick - links{ display: grid; grid - template - columns:repeat(3, minmax(0, 1fr)); gap: 1rem}
.quick - link{
                                                                                                                                                                                display: block; text - decoration:none; background: linear - gradient(180deg,#fff,#f8fbff);border:1px solid var(--border);box-shadow:var(--shadow-soft);border-radius:1.15rem;padding:1rem;color:#0f172a}
.quick - link:hover{ transform: translateY(-2px); box - shadow:var(--shadow)}
.quick - link strong{ display: block; margin - bottom:.25rem}
.quick - link span{ color: var(--muted); font - size:.92rem}

.custom - alert{ border: none; border - radius:1rem; padding: 1rem 1.1rem; font - weight:600; box - shadow:var(--shadow - soft)}
.custom - alert.alert - success{
                                                                                                                                                                                    background:#ecfdf5;color:#065f46}
.custom - alert.alert - warning{
                                                                                                                                                                                        background:#fffbeb;color:#92400e}
.custom - alert.alert - danger{
                                                                                                                                                                                            background:#fef2f2;color:#991b1b}

.login - shell{ min - height:calc(100vh - 160px); display: grid; place - items:center}
.login - panel{ display: grid; grid - template - columns:1.1fr .9fr; gap: 0; background: rgba(255, 255, 255, .92); border: 1px solid rgba(255, 255, 255, .85); border - radius:2rem; overflow: hidden; box - shadow:0 35px 70px rgba(15,23,42,.12); max - width:1100px; width: 100 %}
.login - showcase{
                                                                                                                                                                                                padding: 2rem; background: linear - gradient(135deg,#1d4ed8 0%,#4f46e5 42%,#0ea5e9 100%);color:#fff;position:relative;overflow:hidden}
.login - showcase::before{ content: ""; position: absolute; right: -40px; top: -20px; width: 230px; height: 230px; border - radius:50 %; background: rgba(255, 255, 255, .12)}
.login - showcase::after{ content: ""; position: absolute; left: -30px; bottom: -70px; width: 190px; height: 190px; border - radius:50 %; background: rgba(255, 255, 255, .08)}
.login - showcase > *{ position: relative; z - index:1}
.login - showcase h2{ font - size:2rem; font - weight:800; margin - bottom:.6rem}
.login - showcase p{ color: rgba(255, 255, 255, .92)}
.showcase - points{ display: grid; gap: .85rem; margin - top:1.25rem}
.showcase - point{ display: flex; gap: .75rem; align - items:flex - start; background: rgba(255, 255, 255, .10); padding: .9rem 1rem; border - radius:1rem; border: 1px solid rgba(255, 255, 255, .1)}
.point - icon{ width: 38px; height: 38px; display: grid; place - items:center; background: rgba(255, 255, 255, .16); border - radius:12px; flex - shrink:0}
.login - card{ padding: 2rem 2rem 1.8rem}
.login - card h3{
                                                                                                                                                                                                        font - weight:800; color:#0f172a;margin-bottom:.35rem}
.login - card p{ color: var(--muted)}
.role - hint{
                                                                                                                                                                                                        background:#f8fbff;border:1px dashed #cbd5e1;border-radius:1rem;padding:.9rem 1rem;color:#475569;font-size:.92rem}
.demo - roles{ display: flex; gap: .6rem; flex - wrap:wrap; margin - top:.75rem}
.demo - role{
                                                                                                                                                                                                            background:#eef2ff;color:#4338ca;padding:.4rem .7rem;border-radius:999px;font-weight:700;font-size:.82rem}

@media(max - width:1100px){
    .grid - 4{ grid - template - columns:repeat(2, minmax(0, 1fr))}
    .quick - links{ grid - template - columns:1fr}
    .login - panel{ grid - template - columns:1fr}
                                                                                                                                                                                                                }
                                                                                                                                                                                                                @media(max - width:900px){
    .app - shell{ display: block}
    .sidebar{ position: relative; width: 100 %; height: auto; border - radius:0 0 1.5rem 1.5rem}
    .main - content{ padding: .75rem}
    .topbar{ display: block}
    .topbar - actions{ margin - top:1rem; justify - content:flex - start}
    .grid - 4,.grid - 3,.grid - 2,.form - grid{ grid - template - columns:1fr}
    .page - title{ display: block}
    .dashboard - hero h2{ font - size:1.65rem}
                                                                                                                                                                                                                }
