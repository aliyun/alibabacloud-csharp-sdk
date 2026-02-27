// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class LookupResourceGroupEventsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-30 23:43:16</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MemberShipChange</para>
        /// </summary>
        [NameInMap("EventCategory")]
        [Validation(Required=false)]
        public string EventCategory { get; set; }

        /// <summary>
        /// <para>The attributes used for advanced search.</para>
        /// </summary>
        [NameInMap("LookupAttributes")]
        [Validation(Required=false)]
        public List<LookupResourceGroupEventsRequestLookupAttributes> LookupAttributes { get; set; }
        public class LookupResourceGroupEventsRequestLookupAttributes : TeaModel {
            /// <summary>
            /// <para>The key of the attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the attribute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProjectA</para>
        /// </summary>
        [NameInMap("ResourceGroupDisplayName")]
        [Validation(Required=false)]
        public string ResourceGroupDisplayName { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-9gLOoK****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-30 23:43:16</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
