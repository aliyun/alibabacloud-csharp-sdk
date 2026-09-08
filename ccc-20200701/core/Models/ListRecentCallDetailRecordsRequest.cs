// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListRecentCallDetailRecordsRequest : TeaModel {
        /// <summary>
        /// <para>Fuzzy search criteria in JSON object format. The object contains three properties that can be combined arbitrarily: phoneNumber (fuzzy search by calling or called number), callingNumber (fuzzy search by calling number), and calledNumber (fuzzy search by called number).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;phoneNumber&quot;:&quot;1312121****&quot;,&quot;callingNumber&quot;:&quot;1312121****&quot;,&quot;calledNumber&quot;:&quot;1312121****&quot;}</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>End UNIX timestamp. The default value is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1604639129000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Page ordinal number, ranging from 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, ranging from 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Start UNIX timestamp. The default value is the start time of the current day. The earliest allowed time is 180 days before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1604638129000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
