// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the created application.</para>
        /// </summary>
        [NameInMap("ApplicationInfo")]
        [Validation(Required=false)]
        public InsertApplicationResponseBodyApplicationInfo ApplicationInfo { get; set; }
        public class InsertApplicationResponseBodyApplicationInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the application. The ID is the unique identifier of the application in EDAS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6c733bcd-6efb-47a1-8226-cf722c******</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello-edas-test-1</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The ID of the change process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d0cf569e-dce3-4efb-<b><b>-08b70021</b></b></para>
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is a Docker application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The application is a Docker application.</description></item>
            /// <item><description><b>false</b>: The application is not a Docker application.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Dockerize")]
            [Validation(Required=false)]
            public bool? Dockerize { get; set; }

            /// <summary>
            /// <para>The owner of the application. The owner is the user who created the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>249763358688********</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The port used by the created application. Default value: 8080. You can call the UpdateContainerConfiguration operation to change the port. For more information, see <a href="https://help.aliyun.com/document_detail/149403.html">UpdateContainerConfiguration</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tdy218@1362469756xxxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The application name test-hsy-C5039-paas-6 had been created successfully.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4264F69C-686C-4107-B493-0599C8xxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
