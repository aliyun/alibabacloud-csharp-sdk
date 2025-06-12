// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request.``</para>
        /// <para>When you call the operation for the first time, if the total number of returned entries exceeds the value of <c>MaxItems</c>, the entries are truncated. The system returns entries based on the value of <c>MaxItems</c> and does not return the excess entries. In this case, the value of the response parameter <c>IsTruncated</c> is <c>true</c>, and <c>Marker</c> is returned. In the next call, you can use the value of <c>Marker</c> and maintain the settings of the other request parameters to query the excess entries. You can repeat the call until the value of <c>IsTruncated</c> becomes <c>false</c>. This way, all entries are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
