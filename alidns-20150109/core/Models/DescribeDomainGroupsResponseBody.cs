// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name groups.</para>
        /// </summary>
        [NameInMap("DomainGroups")]
        [Validation(Required=false)]
        public DescribeDomainGroupsResponseBodyDomainGroups DomainGroups { get; set; }
        public class DescribeDomainGroupsResponseBodyDomainGroups : TeaModel {
            [NameInMap("DomainGroup")]
            [Validation(Required=false)]
            public List<DescribeDomainGroupsResponseBodyDomainGroupsDomainGroup> DomainGroup { get; set; }
            public class DescribeDomainGroupsResponseBodyDomainGroupsDomainGroup : TeaModel {
                /// <summary>
                /// <para>The number of domain name groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DomainCount")]
                [Validation(Required=false)]
                public long? DomainCount { get; set; }

                /// <summary>
                /// <para>The ID of the domain name group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>defaultGroup: the default group</description></item>
                /// <item><description>If an empty string is returned, it indicates the group that contains all domain names.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2223</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the domain name group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyGroup</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1 to 100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
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
        public long? TotalCount { get; set; }

    }

}
