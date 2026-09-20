// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class UpgradeMultiZoneClusterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the multi-zone instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-***************</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The component names. You can specify multiple component names separated by commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LINDORM</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string Components { get; set; }

        /// <summary>
        /// <para>The names of the components that need to be restarted after the upgrade. You can specify multiple component names separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>LPROXY</para>
        /// </summary>
        [NameInMap("RestartComponents")]
        [Validation(Required=false)]
        public string RestartComponents { get; set; }

        /// <summary>
        /// <para>The execution mode. If UpgradeInsName is not empty, the mode is forcibly set to single. If UpgradeInsName is empty and RunMode is not specified, the default value is serial. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>serial: all sub-instances are upgraded.</description></item>
        /// <item><description>single: only the specified sub-instance is upgraded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>serial</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        /// <summary>
        /// <para>The name of the sub-instance to upgrade. You can obtain this value from the MultiZoneInstanceModels field in the response of the <a href="~~DescribeMultiZoneCluster~~">DescribeMultiZoneCluster</a> operation. This parameter is optional. If you do not specify this parameter, all sub-instances are upgraded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-t4n40m3171t4******-az-b</para>
        /// </summary>
        [NameInMap("UpgradeInsName")]
        [Validation(Required=false)]
        public string UpgradeInsName { get; set; }

        /// <summary>
        /// <para>The RPM version to upgrade to. If you do not specify this parameter, the components are upgraded to the latest version. If you specify multiple values for Components, you must also specify the same number of values for Versions, separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-apsara-lindorm-2.1.20-20200518175539.alios7.x86_64</para>
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public string Versions { get; set; }

    }

}
