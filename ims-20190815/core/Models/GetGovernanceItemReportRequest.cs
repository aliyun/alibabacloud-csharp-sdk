// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetGovernanceItemReportRequest : TeaModel {
        /// <summary>
        /// <para>The check item. For more information, see <a href="https://help.aliyun.com/zh/ram/user-guide/overview-of-cloud-governance-for-ram?spm=a2c4g.11174283.0.0.88b3de53tfL5XG#section-q06-p9p-8vl">Identity and access governance check items</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SSOLoginEnabled</para>
        /// </summary>
        [NameInMap("GovernanceItemType")]
        [Validation(Required=false)]
        public string GovernanceItemType { get; set; }

        /// <summary>
        /// <para>If the response is truncated, use the <c>Marker</c> to retrieve the subsequent content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The number of entries to return. If the response is truncated because the number of entries exceeds the value of <c>MaxItems</c>, the value of the <c>IsTruncated</c> parameter is true.</para>
        /// <para>Valid values: 1 to 1000. Default value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public string MaxItems { get; set; }

    }

}
