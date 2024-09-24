// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListQueryRaspAppInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The installation information of the RASP-enabled application.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListQueryRaspAppInfoResponseBodyData> Data { get; set; }
        public class ListQueryRaspAppInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the RASP-enabled application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rasp-app</para>
            /// </summary>
            [NameInMap("RaspAppName")]
            [Validation(Required=false)]
            public string RaspAppName { get; set; }

            /// <summary>
            /// <para>The online status of the RASP-enabled applications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: All RASP-enabled applications are online.</description></item>
            /// <item><description><b>1</b>: Part of the RASP-enabled applications are online.</description></item>
            /// <item><description><b>2</b>: All RASP-enabled applications are offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RaspOnlineStatus")]
            [Validation(Required=false)]
            public int? RaspOnlineStatus { get; set; }

            /// <summary>
            /// <para>The installation status of the RASP-enabled application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SUCCESS</b>: The RASP-enabled application is installed.</description></item>
            /// <item><description><b>FAIL</b>: The RASP-enabled application fails to be installed.</description></item>
            /// <item><description><b>INSTALL</b>: The RASP-enabled application is being installed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("RaspStatus")]
            [Validation(Required=false)]
            public string RaspStatus { get; set; }

            /// <summary>
            /// <para>The result returned if the push fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT_OFFLINE</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6690a46c-0edb-4663-a641-3629d1a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A975D03-5F49-5354-B2CB-3918D5DA431A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
