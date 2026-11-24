// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The creation time, in UNIX timestamp format. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1571926439000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xkx6vujuhay0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance issue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The instance issue. Valid values:
        /// OSS_TOO_MANY_BUCKETS: The number of OSS buckets exceeds the limit.</para>
        /// <para>OSS_BUCKET_ALREADY_EXISTS: An OSS bucket with the same name already exists.</para>
        /// <para>OSS_SERVICE_ROLE_UNAUTHORIZED: OSS permissions are not authorized.</para>
        /// <para>USER_NOT_REGISTERED_BY_REAL_NAME: The China site account has not completed real-name verification when purchasing an OSS bucket on the China site</para>
        /// </summary>
        [NameInMap("InstanceIssue")]
        [Validation(Required=false)]
        public string InstanceIssue { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shanghai-instance1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance specification. Valid values:
        /// Enterprise_Basic: basic instance.
        /// Enterprise_Standard: standard instance.
        /// Enterprise_Advanced: advanced instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise_Basic</para>
        /// </summary>
        [NameInMap("InstanceSpecification")]
        [Validation(Required=false)]
        public string InstanceSpecification { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PENDING</c>: Initializing.</para>
        /// </description></item>
        /// <item><description><para><c>INIT_ERROR</c>: Initialization failed.</para>
        /// </description></item>
        /// <item><description><para><c>STARTING</c>: Starting.</para>
        /// </description></item>
        /// <item><description><para><c>RUNNING</c>: Running.</para>
        /// </description></item>
        /// <item><description><para><c>STOPPING</c>: Stopping.</para>
        /// </description></item>
        /// <item><description><para><c>STOPPED</c>: Stopped.</para>
        /// </description></item>
        /// <item><description><para><c>DELETING</c>: Deleting.</para>
        /// </description></item>
        /// <item><description><para><c>DELETED</c>: Deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The modification time, in UNIX timestamp format. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1571926560000</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EF34B18-4228-470C-860C-D28597CF010E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmv36i4isx****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tag collection of the instance.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetInstanceResponseBodyTags> Tags { get; set; }
        public class GetInstanceResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_key</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_value</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
