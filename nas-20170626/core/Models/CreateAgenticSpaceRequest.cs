// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateAgenticSpaceRequest : TeaModel {
        /// <summary>
        /// <para>The zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("Azone")]
        [Validation(Required=false)]
        public string Azone { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, and you must make sure that the value is unique among different requests.</para>
        /// <para>The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the Agentic space.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>It must start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>It can contain digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AgenticSpace Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on this modification request. A dry run checks the validity of parameters and dependencies without actually modifying the instance or incurring fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: sends a check request. The protocol service is not modified. The check items include whether required parameters are specified, the request format, and business limits and dependencies. If the check fails, an error is returned. If the check succeeds, the HTTP status code 200 is returned.</description></item>
        /// <item><description>false (default): sends a normal request. If the check succeeds, the protocol service is directly modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The absolute path of the file. Only first-level directories are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/path/</para>
        /// </summary>
        [NameInMap("FileSystemPath")]
        [Validation(Required=false)]
        public string FileSystemPath { get; set; }

        /// <summary>
        /// <para>The quota information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public CreateAgenticSpaceRequestQuota Quota { get; set; }
        public class CreateAgenticSpaceRequestQuota : TeaModel {
            /// <summary>
            /// <para>The maximum number of files allowed by the quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Minimum value: 10,000.</para>
            /// </description></item>
            /// <item><description><para>Maximum value: 100,000,000.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("FileCountLimit")]
            [Validation(Required=false)]
            public long? FileCountLimit { get; set; }

            /// <summary>
            /// <para>The total capacity limit of the quota. Unit: bytes.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Minimum value: 10,737,418,240 (10 GiB).</description></item>
            /// <item><description>Maximum value: 1,099,511,627,776,000 (1,024,000 GiB).</description></item>
            /// <item><description>Step: 1,073,741,824 (1 GiB).</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10737418240</para>
            /// </summary>
            [NameInMap("SizeLimit")]
            [Validation(Required=false)]
            public long? SizeLimit { get; set; }

        }

    }

}
