// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class SendFileRequest : TeaModel {
        /// <summary>
        /// <para>The content of the file. The file must not exceed 32 KB in size after it is encoded in Base64.</para>
        /// <list type="bullet">
        /// <item><description>If <c>ContentType</c> is set to <c>PlainText</c>, the value of Content is in plaintext.</description></item>
        /// <item><description>If <c>ContentType</c> is set to <c>Base64</c>, the value of Content is Base64-encoded.</description></item>
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
        /// <para>The content type of the file. Valid values:</para>
        /// <para>PlainText Base64 Default value: PlainText.</para>
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
        /// <para>The user group of the file. This parameter takes effect only on Linux instances. Default value: root. The value can be up to 64 characters in length.</para>
        /// <para>Note If you want to use a non-root user group, make sure that the user group exists in the instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FileGroup")]
        [Validation(Required=false)]
        public string FileGroup { get; set; }

        /// <summary>
        /// <para>The permissions on the file. This parameter takes effect only on Linux instances. You can configure this parameter in the same way as you configure the chmod command.</para>
        /// <para>Default value: 0644: the owner of the file has the read and write permission. The user group of the file and other users have read-only permission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0644</para>
        /// </summary>
        [NameInMap("FileMode")]
        [Validation(Required=false)]
        public string FileMode { get; set; }

        /// <summary>
        /// <para>The owner of the file. This parameter takes effect only on Linux instances. Default value: root.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("FileOwner")]
        [Validation(Required=false)]
        public string FileOwner { get; set; }

        /// <summary>
        /// <para>The file name. The name can be up to 255 characters in length and can contain any characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file.txt</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The node list.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeIdList")]
        [Validation(Required=false)]
        public List<string> NodeIdList { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite file with the same name in the destination directory.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>The directory in the Lingjun node to which the file is sent. If the specified directory does not exist, the system creates the directory automatically.</para>
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
        /// <item><description>If the specified timeout period is less than 10 seconds, the system sets the timeout period to 10 seconds to ensure that the file can be sent.</description></item>
        /// </list>
        /// <para>Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
