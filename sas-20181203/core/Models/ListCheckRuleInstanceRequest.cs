// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckRuleInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page when performing a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Instance list.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<ListCheckRuleInstanceRequestInstanceList> InstanceList { get; set; }
        public class ListCheckRuleInstanceRequestInstanceList : TeaModel {
            /// <summary>
            /// <para>Asset instance ID.</para>
            /// <remarks>
            /// <para>Call the <a href="~~ListCheckInstanceResult~~">ListCheckInstanceResult</a> interface to get this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9fdluqx20mp2x7****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region where the asset is located.</para>
            /// <remarks>
            /// <para>Call the <a href="~~ListCheckInstanceResult~~">ListCheckInstanceResult</a> interface to get this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongkong</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of items per page in a paginated query. The default value is <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Rule ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2590599.html">LisCheckRule</a> interface to get this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
