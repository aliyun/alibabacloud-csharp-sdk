// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListMultiAccountDeliveryChannelsRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <para>If the number of returned entries exceeds the <c>MaxResults</c> value, the entries are truncated and this token is returned. To fetch the remaining entries, pass this token in the subsequent request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAARfZmVDe9NvRXloR5+8CK9nNJufMdRA7W1miLC1P****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
