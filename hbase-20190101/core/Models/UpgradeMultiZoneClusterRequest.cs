// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class UpgradeMultiZoneClusterRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-***************</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LINDORM</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string Components { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LPROXY</para>
        /// </summary>
        [NameInMap("RestartComponents")]
        [Validation(Required=false)]
        public string RestartComponents { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>serial</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ld-t4n40m3171t4******-az-b</para>
        /// </summary>
        [NameInMap("UpgradeInsName")]
        [Validation(Required=false)]
        public string UpgradeInsName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>t-apsara-lindorm-2.1.20-20200518175539.alios7.x86_64</para>
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public string Versions { get; set; }

    }

}
