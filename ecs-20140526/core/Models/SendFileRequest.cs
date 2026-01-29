// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class SendFileRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The content of the file. The file must not exceed 32 KB in size after it is encoded in Base64.</para>
        /// <list type="bullet">
        /// <item><description>If <c>ContentType</c> is set to <c>PlainText</c>, the value of Content is in plaintext.</description></item>
        /// <item><description>If <c>ContentType</c> is set to <c>Base64</c>, the value of Content is Base64-encoded.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/bash  echo &quot;Current User is :&quot;  echo $(ps | grep &quot;$$&quot; | awk \&quot;{print $2}\&quot;)  --------  oss://bucketName/objectName</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The content type of the file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: The file content is not encoded.</description></item>
        /// <item><description>Base64: The file content is encoded in Base64.</description></item>
        /// </list>
        /// <para>Default value: PlainText.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The description of the file. The description can be up to 512 characters in length and can contain any characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test file.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The group of the file. This parameter takes effect only on Linux instances. Default value: root. The value can be up to 64 characters in length.</para>
        /// <remarks>
        /// <para> If you want to use a non-root user group, make sure that the user group exists in the instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FileGroup")]
        [Validation(Required=false)]
        public string FileGroup { get; set; }

        /// <summary>
        /// <para>The permissions on the file. This parameter takes effect only on Linux instances. You can configure this parameter in the same way as you configure the chmod command.</para>
        /// <para>Default value: 0644, which indicates that the owner of the file has the read and write permissions on the file and that the user group of the file and other users have the read-only permissions on the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0644</para>
        /// </summary>
        [NameInMap("FileMode")]
        [Validation(Required=false)]
        public string FileMode { get; set; }

        /// <summary>
        /// <para>The owner of the file. This parameter takes effect only on Linux instances. Default value: root. The value can be up to 64 characters in length.</para>
        /// <remarks>
        /// <para> If you want to use a non-root user, make sure that the user exists in the instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FileOwner")]
        [Validation(Required=false)]
        public string FileOwner { get; set; }

        /// <summary>
        /// <para>The IDs of instances to which to send the file. You can specify up to 50 instance IDs in each request. Valid values of N: 1 to 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp185dy2o3o6n****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the file. The name can be up to 255 characters in length and can contain any characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file.txt</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite a file in the destination directory if the file has the same name as the sent file.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance to which to send the file. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. When you specify this parameter, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The instance specified by the InstanceId parameter must belong to the specified resource group.</description></item>
        /// <item><description>If you specify this parameter, you can call the <a href="https://help.aliyun.com/document_detail/184117.html">DescribeSendFileResults</a> operation to query file sending results in the specified resource group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags to add to the file sending task.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<SendFileRequestTag> Tag { get; set; }
        public class SendFileRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the file sending task. Valid values of N: 1 to 20. The tag key cannot be an empty string.</para>
            /// <para>If a single tag is specified to query resources, up to 1,000 resources that have this tag added can be displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all the tags added can be displayed in the response. To query more than 1,000 resources that have specified tags, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the file sending task. Valid values of N: 1 to 20. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The destination directory on the instance to which to send the file. If the specified directory does not exist, the system creates the directory on the instance. The value cannot exceed 255 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home</para>
        /// </summary>
        [NameInMap("TargetDir")]
        [Validation(Required=false)]
        public string TargetDir { get; set; }

        /// <summary>
        /// <para>The timeout period for the file sending task. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>A timeout error occurs when a file cannot be sent because the process slows down or because a specific module or Cloud Assistant Agent does not exist.</description></item>
        /// <item><description>If the specified timeout period is less than 10 seconds, the system sets the timeout period to 10 seconds to ensure that the file can be sent to the instances.</description></item>
        /// </list>
        /// <para>Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
