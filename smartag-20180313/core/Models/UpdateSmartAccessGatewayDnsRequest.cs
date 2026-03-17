// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class UpdateSmartAccessGatewayDnsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query only the SAG instances that belong to another Alibaba Cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CrossAccount")]
        [Validation(Required=false)]
        public bool? CrossAccount { get; set; }

        /// <summary>
        /// <para>The IP address of the primary DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.XX.XX</para>
        /// </summary>
        [NameInMap("MasterDns")]
        [Validation(Required=false)]
        public string MasterDns { get; set; }

        /// <summary>
        /// <para>The region ID of the SAG instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the SAG instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>147304382796****</para>
        /// </summary>
        [NameInMap("ResourceUid")]
        [Validation(Required=false)]
        public string ResourceUid { get; set; }

        /// <summary>
        /// <para>The ID of the Smart Access Gateway (SAG) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-3manef62evrfr6****</para>
        /// </summary>
        [NameInMap("SagInsId")]
        [Validation(Required=false)]
        public string SagInsId { get; set; }

        /// <summary>
        /// <para>The serial number of the SAG device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sagf4ea****</para>
        /// </summary>
        [NameInMap("SagSn")]
        [Validation(Required=false)]
        public string SagSn { get; set; }

        /// <summary>
        /// <para>The IP address of the secondary DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.XX.XX</para>
        /// </summary>
        [NameInMap("SlaveDns")]
        [Validation(Required=false)]
        public string SlaveDns { get; set; }

    }

}
