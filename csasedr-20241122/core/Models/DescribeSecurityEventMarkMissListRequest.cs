// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class DescribeSecurityEventMarkMissListRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the page number of the returned page. Default value: <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The disposal method of the rule. The current query does not filter by this field, and you do not need to set it. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>auto_add_white</b>: Automatic whitelisting.</description></item>
        /// <item><description><b>defense_not_notification</b>: Defense only without notification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>auto_add_white</para>
        /// </summary>
        [NameInMap("DisposalWay")]
        [Validation(Required=false)]
        public string DisposalWay { get; set; }

        /// <summary>
        /// <para>The name of the alert event (subtype).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Untrusted process startup</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return in a single query. This field is reserved for compatibility. The backend currently uses CurrentPage and PageSize for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of whitelist rules to return on each page in a paging query. Default value: <b>20</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This field is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
