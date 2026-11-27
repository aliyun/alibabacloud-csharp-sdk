// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class SendFileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The file content. The size of the file content cannot exceed 32 KB after Base64 encoding.</para>
        /// <list type="bullet">
        /// <item><description>If the ContentType parameter is set to PlainText, this field contains plain text.</description></item>
        /// <item><description>If the ContentType parameter is set to Base64, this field contains Base64-encoded text.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/bash echo &quot;Current User is :&quot; echo $(ps | grep &quot;$$&quot; | awk &quot;{print $2}&quot;) -------- oss://bucketName/objectName</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The content type of the file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText: plain text.</description></item>
        /// <item><description>Base64: Base64-encoded text.
        /// Default value: PlainText.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The description. The description supports all character sets and can be up to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test file.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The file group. This parameter takes effect only on Linux instances. Default value: root. The value can be up to 64 characters in length.
        /// Note
        /// When you use a different group, make sure that the group exists on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FileGroup")]
        [Validation(Required=false)]
        public string FileGroup { get; set; }

        /// <summary>
        /// <para>The file permissions. This parameter takes effect only on Linux instances. The setting method is the same as that of the chmod command.
        /// Default value: 0644, which indicates that the owner has read and write permissions, and the group and others have read-only permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0644</para>
        /// </summary>
        [NameInMap("FileMode")]
        [Validation(Required=false)]
        public string FileMode { get; set; }

        /// <summary>
        /// <para>The file owner. This parameter takes effect only on Linux instances. Default value: root.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("FileOwner")]
        [Validation(Required=false)]
        public string FileOwner { get; set; }

        /// <summary>
        /// <para>The file name. The name supports all character sets and can be up to 255 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file.txt</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of node IDs. The node IDs must belong to created Lingjun nodes. You can call the ListClusterNodes or ListFreeNodes operation to query the node IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeIdList")]
        [Validation(Required=false)]
        public string NodeIdListShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite the file if a file with the same name already exists in the target directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Overwrites the file.</description></item>
        /// <item><description>false: Does not overwrite the file.
        /// Default value: false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The target folder on the Lingjun nodes to which the file is delivered. If the folder does not exist, automatic creation is performed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home</para>
        /// </summary>
        [NameInMap("TargetDir")]
        [Validation(Required=false)]
        public string TargetDir { get; set; }

        /// <summary>
        /// <para>The timeout period for delivering the file. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>A timeout occurs if the file cannot be delivered due to process issues, missing modules, or a missing Cloud Assistant Agent.</description></item>
        /// <item><description>If the specified timeout period is less than 10 seconds, the system automatically sets it to 10 seconds to ensure successful delivery.
        /// Default value: 60.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
