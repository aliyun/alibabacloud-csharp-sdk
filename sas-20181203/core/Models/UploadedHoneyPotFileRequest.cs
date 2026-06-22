// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UploadedHoneyPotFileRequest : TeaModel {
        /// <summary>
        /// <para>The FileKey used to upload the file.</para>
        /// <remarks>
        /// <para>Format: HONEYPOT_FILE/{timestamp}_{custom_file_name}.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HONEYPOT_FILE/1601097845544644_********</para>
        /// </summary>
        [NameInMap("FileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        /// <summary>
        /// <para>The name of the uploaded file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trojan.zip</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The file type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/zip</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The name of the honeypot image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ruoyi</para>
        /// </summary>
        [NameInMap("HoneypotImageName")]
        [Validation(Required=false)]
        public string HoneypotImageName { get; set; }

        /// <summary>
        /// <para>The language type of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the honeypot management node.</para>
        /// <remarks>
        /// <para>Call the <a href="~~ListHoneypotNode~~">ListHoneypotNode</a> operation to obtain this value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cc427e14-f257-4670-9d2b-d83bbbe*****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The template prompt corresponding to the uploaded file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;help\&quot;:\&quot;.zip\&quot;,\&quot;label\&quot;:\&quot;file\&quot;,\&quot;type\&quot;:\&quot;file\&quot;,\&quot;key\&quot;:\&quot;ftpfiles.zip\&quot;}</para>
        /// </summary>
        [NameInMap("TemplateExtra")]
        [Validation(Required=false)]
        public string TemplateExtra { get; set; }

    }

}
