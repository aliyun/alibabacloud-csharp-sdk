// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ListDeviceCredentialClientIdResponseBody : TeaModel {
        /// <summary>
        /// <para>Returns the information list.</para>
        /// </summary>
        [NameInMap("DeviceCredentialClientIdList")]
        [Validation(Required=false)]
        public ListDeviceCredentialClientIdResponseBodyDeviceCredentialClientIdList DeviceCredentialClientIdList { get; set; }
        public class ListDeviceCredentialClientIdResponseBodyDeviceCredentialClientIdList : TeaModel {
            /// <summary>
            /// <para>Client list.</para>
            /// </summary>
            [NameInMap("ClientIdList")]
            [Validation(Required=false)]
            public List<string> ClientIdList { get; set; }

            /// <summary>
            /// <para>Indicates whether there is a token (Token) for the next query. Values: </para>
            /// <list type="bullet">
            /// <item><description>For the first query and when there is no next query, this field does not need to be filled. </description></item>
            /// <item><description>If there is a next query, the value should be the NextToken returned from the previous API call.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>634dxxxxx75b5f</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The current page number of the returned query records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public string PageNo { get; set; }

            /// <summary>
            /// <para>The maximum number of results to display per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>Total number of query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public string Total { get; set; }

        }

        /// <summary>
        /// <para>Public parameters, each request ID is unique and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>020F6A43-19E6-4B6E-B846-44EB31DF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
