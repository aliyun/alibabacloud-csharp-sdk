// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgQueryDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The start time of the query range. Example: &quot;2026-06-26 00:00:00&quot;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-26 00:00:00</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// <para>The end time of the query range. Example: &quot;2026-06-30 23:59:59&quot;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-30 23:59:59</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ODPS.ODPS</description></item>
        /// <item><description>EMR</description></item>
        /// <item><description>HOLO.POSTGRES</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS.ODPS</para>
        /// </summary>
        [NameInMap("EngineName")]
        [Validation(Required=false)]
        public string EngineName { get; set; }

        /// <summary>
        /// <para>The internal IP address of the ECU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.107.80.20</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The region to which the IP address belongs. Example: China-Beijing-Beijing, or internal IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China-Beijing-Beijing.</para>
        /// </summary>
        [NameInMap("IpAare")]
        [Validation(Required=false)]
        public string IpAare { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123541234</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The project workspace name (essentially ProjectName). Example: dsg_demo_gw.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsg_demo_gw</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The minimum value of the export volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Rows")]
        [Validation(Required=false)]
        public int? Rows { get; set; }

        /// <summary>
        /// <para>The type of triggered sensitive rule. Example: Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Name.</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The classification level. Example: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SensLevel")]
        [Validation(Required=false)]
        public string SensLevel { get; set; }

        /// <summary>
        /// <para>The operator account. Example: dsg_test.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsg_test</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
