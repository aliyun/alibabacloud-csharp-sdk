// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The token for querying the next page of results. You do not need to specify <c>Marker</c> for the first API call.</para>
        /// <para>If the total number of returned entries exceeds the <c>MaxItems</c> limit during the first API call, the data is truncated and only <c>MaxItems</c> entries are returned. In this case, the <c>IsTruncated</c> response parameter is <c>true</c> and a <c>Marker</c> is returned. You can use the <c>Marker</c> returned from the previous call to continue calling the API with the other request parameters unchanged to query the truncated data. You can repeat this process until <c>IsTruncated</c> is <c>false</c>, which indicates that all data has been queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public int? MaxItems { get; set; }

    }

}
