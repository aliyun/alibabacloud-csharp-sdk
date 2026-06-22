// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAgentlessRiskUuidRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page when using paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the asset instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp1g6wxdwps7s9dz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the asset instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca_cpm_****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The public IP address of the asset to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.XX.XX</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>The private IP address of the asset to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.26.XX.XX</para>
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oracle-win-001****</para>
        /// </summary>
        [NameInMap("MachineName")]
        [Validation(Required=false)]
        public string MachineName { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page when using paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether risks exist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Risks exist.</description></item>
        /// <item><description><b>false</b>: Risks do not exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Risk")]
        [Validation(Required=false)]
        public bool? Risk { get; set; }

        /// <summary>
        /// <para>The name of the detection target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source-test-obj-0****</para>
        /// </summary>
        [NameInMap("TargetName")]
        [Validation(Required=false)]
        public string TargetName { get; set; }

        /// <summary>
        /// <para>The object type of the detection target. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: host snapshot</description></item>
        /// <item><description><b>2</b>: host image</description></item>
        /// <item><description><b>3</b>: user snapshot</description></item>
        /// <item><description><b>4</b>: user custom image</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

    }

}
