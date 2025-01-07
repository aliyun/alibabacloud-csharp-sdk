// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetModuleConfigStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetModuleConfigStatusResponseBodyData Data { get; set; }
        public class GetModuleConfigStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The check results of the service modules.</para>
            /// </summary>
            [NameInMap("ModuleConfigResults")]
            [Validation(Required=false)]
            public List<GetModuleConfigStatusResponseBodyDataModuleConfigResults> ModuleConfigResults { get; set; }
            public class GetModuleConfigStatusResponseBodyDataModuleConfigResults : TeaModel {
                /// <summary>
                /// <para>The name of the check item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Ransom</b>: The anti-ransomware policy is enabled.</description></item>
                /// <item><description><b>WebLock</b>: The web tamper proofing feature is enabled.</description></item>
                /// <item><description><b>Rasp</b>: Applications are added to the application protection feature.</description></item>
                /// <item><description><b>Image</b>: The container images that can be scanned are specified.</description></item>
                /// <item><description><b>Virus</b>: The periodic virus scan policy is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Ransom</para>
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// <para>Indicates whether the service module passed the status check. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Pass")]
                [Validation(Required=false)]
                public bool? Pass { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>843E4805-****-7EE12FA8DBFD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
