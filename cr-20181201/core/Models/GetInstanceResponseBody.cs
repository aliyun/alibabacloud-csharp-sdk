// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Return value</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1571926439000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the Container Registry instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xkx6vujuhay0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The issue occurs on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>实例问题，取值：
        /// OSS_TOO_MANY_BUCKETS：OSS Bucket 数量超限</para>
        /// <para>OSS_BUCKET_ALREADY_EXISTS：同名 OSS Bucket 已存在</para>
        /// <para>OSS_SERVICE_ROLE_UNAUTHORIZED：OSS 权限未授权</para>
        /// <para>USER_NOT_REGISTERED_BY_REAL_NAME：国际站账号在购买中国站 OSS Bucket 时未进行实名认证</para>
        /// </summary>
        [NameInMap("InstanceIssue")]
        [Validation(Required=false)]
        public string InstanceIssue { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shanghai-instance1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The edition of the instance. Valid values: Enterprise_Basic: Basic Edition instances Enterprise_Standard: Standard Edition instances Enterprise_Advanced: Advanced Edition instances</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise_Basic</para>
        /// </summary>
        [NameInMap("InstanceSpecification")]
        [Validation(Required=false)]
        public string InstanceSpecification { get; set; }

        /// <summary>
        /// <para>The status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PENDING</c>: The instance is being initialized.</description></item>
        /// <item><description><c>INIT_ERROR</c>: The instance failed to be initialized.</description></item>
        /// <item><description><c>STARTING</c>: The instance is being started.</description></item>
        /// <item><description><c>RUNNING</c>: The instance is running.</description></item>
        /// <item><description><c>STOPPING</c>: The instance is being stopped.</description></item>
        /// <item><description><c>STOPPED</c>: The instance is stopped.</description></item>
        /// <item><description><c>DELETING</c>: The instance is being deleted.</description></item>
        /// <item><description><c>DELETED</c>: The instance is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The time when the instance was last modified.</para>
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
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmv36i4isx****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the instance.</para>
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
