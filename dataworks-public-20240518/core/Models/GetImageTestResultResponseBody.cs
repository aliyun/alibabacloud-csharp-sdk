// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetImageTestResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of the image test result.</para>
        /// </summary>
        [NameInMap("TestResult")]
        [Validation(Required=false)]
        public GetImageTestResultResponseBodyTestResult TestResult { get; set; }
        public class GetImageTestResultResponseBodyTestResult : TeaModel {
            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom_image_xxxx_xxxx</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The test result message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test finished</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The operation time, represented as a 64-bit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1727055811000</para>
            /// </summary>
            [NameInMap("OperateTime")]
            [Validation(Required=false)]
            public long? OperateTime { get; set; }

            /// <summary>
            /// <para>The process ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>582d4896-d224-413b-b883-239eeebe0bc5</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>The image publish status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Untest: Not tested.</description></item>
            /// <item><description>Testing: Testing in progress.</description></item>
            /// <item><description>TestFailed: Test failed.</description></item>
            /// <item><description>Unpublished: Not published.</description></item>
            /// <item><description>Publishing: Publishing in progress.</description></item>
            /// <item><description>Published: Published.</description></item>
            /// <item><description>PublishFailed: Publish failed.</description></item>
            /// <item><description>Building: Building in progress.</description></item>
            /// <item><description>BuildSuccess: Build succeeded.</description></item>
            /// <item><description>BuildFailed: Build failed.</description></item>
            /// <item><description>Accelerating: Acceleration in progress.</description></item>
            /// <item><description>AccelerateSuccess: Acceleration succeeded.</description></item>
            /// <item><description>AccelerateFailed: Acceleration failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unpublished</para>
            /// </summary>
            [NameInMap("PublishStage")]
            [Validation(Required=false)]
            public string PublishStage { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Serverless_res_group_****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public long? ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The test process status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>running: Running.</description></item>
            /// <item><description>completed: Completed.</description></item>
            /// <item><description>failed: Failed.</description></item>
            /// <item><description>cancelled: Cancelled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
