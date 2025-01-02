// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class SendFileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The content of the file. After Base64 encoding, the size cannot exceed 32 KB.</para>
        /// <list type="bullet">
        /// <item><description>When the <c>ContentType</c> parameter is <c>PlainText</c>, this field is plain text.</description></item>
        /// <item><description>When the <c>ContentType</c> parameter is <c>Base64</c>, this field is Base64 encoded text.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/bash echo &quot;Current User is :&quot; echo $(ps | grep &quot;$$&quot; | awk \&quot;{print $2}\&quot;) -------- oss://bucketName/objectName</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The content type of the file.</para>
        /// <para>PlainText: Plain text.
        /// Base64: Base64 encoded.
        /// The default value is PlainText.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>Description information. Supports all character sets, and the length must not exceed 512 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test file.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The group of the file. Applies only to Linux instances, and the default is root. The length must not exceed 64 characters.</para>
        /// <para>Note
        /// When using other groups, ensure that the group exists in the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FileGroup")]
        [Validation(Required=false)]
        public string FileGroup { get; set; }

        /// <summary>
        /// <para>The permissions of the file. Applies only to Linux instances, and the setting method is the same as the chmod command.</para>
        /// <para>The default value is 0644, which means the user has read and write permissions, while the group and other users have read-only permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0644</para>
        /// </summary>
        [NameInMap("FileMode")]
        [Validation(Required=false)]
        public string FileMode { get; set; }

        /// <summary>
        /// <para>The owner of the file. Applies only to Linux instances, and the default is root.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("FileOwner")]
        [Validation(Required=false)]
        public string FileOwner { get; set; }

        /// <summary>
        /// <para>The name of the file. Supports all character sets, and the length must not exceed 255 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file.txt</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>List of nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeIdList")]
        [Validation(Required=false)]
        public string NodeIdListShrink { get; set; }

        /// <summary>
        /// <para>Whether to overwrite the file if a file with the same name already exists in the target directory.</para>
        /// <list type="bullet">
        /// <item><description>true: Overwrite.</description></item>
        /// <item><description>false: Do not overwrite.</description></item>
        /// </list>
        /// <para>The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The directory in the target Lingjun node where the file will be sent. If it does not exist, it will be automatically created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home</para>
        /// </summary>
        [NameInMap("TargetDir")]
        [Validation(Required=false)]
        public string TargetDir { get; set; }

        /// <summary>
        /// <para>The timeout for sending the file. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>A timeout may occur due to process reasons, missing modules, or missing Cloud Assistant Agent.</description></item>
        /// <item><description>If the set timeout is less than 10 seconds, to ensure successful delivery, the system will automatically set the timeout to 10 seconds.</description></item>
        /// </list>
        /// <para>The default value is 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
