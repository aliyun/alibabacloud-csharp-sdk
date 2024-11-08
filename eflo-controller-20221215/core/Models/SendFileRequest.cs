// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class SendFileRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/bash echo &quot;Current User is :&quot; echo $(ps | grep &quot;$$&quot; | awk \&quot;{print $2}\&quot;) -------- oss://bucketName/objectName</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is a test file.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FileGroup")]
        [Validation(Required=false)]
        public string FileGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0644</para>
        /// </summary>
        [NameInMap("FileMode")]
        [Validation(Required=false)]
        public string FileMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("FileOwner")]
        [Validation(Required=false)]
        public string FileOwner { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file.txt</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeIdList")]
        [Validation(Required=false)]
        public List<string> NodeIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home</para>
        /// </summary>
        [NameInMap("TargetDir")]
        [Validation(Required=false)]
        public string TargetDir { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
