// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeGrantRulesToCenResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the authorization.</para>
        /// </summary>
        [NameInMap("CenGrantRules")]
        [Validation(Required=false)]
        public DescribeGrantRulesToCenResponseBodyCenGrantRules CenGrantRules { get; set; }
        public class DescribeGrantRulesToCenResponseBodyCenGrantRules : TeaModel {
            [NameInMap("CbnGrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantRulesToCenResponseBodyCenGrantRulesCbnGrantRule> CbnGrantRule { get; set; }
            public class DescribeGrantRulesToCenResponseBodyCenGrantRulesCbnGrantRule : TeaModel {
                /// <summary>
                /// <para>The ID of the authorized CEN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-9gsm1q2yh1prpt****</para>
                /// </summary>
                [NameInMap("CenInstanceId")]
                [Validation(Required=false)]
                public string CenInstanceId { get; set; }

                /// <summary>
                /// <para>The UID of the Alibaba Cloud account to which the authorized CEN instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>132193271328****</para>
                /// </summary>
                [NameInMap("CenOwnerId")]
                [Validation(Required=false)]
                public long? CenOwnerId { get; set; }

                /// <summary>
                /// <para>The time when the instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-15T09:26:36Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5BB78C8-5F41-464F-B9FF-5E0A7198BA26</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
