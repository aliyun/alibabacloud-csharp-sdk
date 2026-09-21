// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UploadedHoneyPotFileRequest : TeaModel {
        /// <summary>
        /// <para>The FileKey used for the uploaded file.</para>
        /// <remarks>
        /// <para>Format: HONEYPOT_FILE/{timestamp}_{custom_file_name}</para>
        /// </remarks>
        /// <para>You must obtain this value by calling GetHoneyPotUploadPolicyInfo and use the returned Data.Key. Do not construct this value manually based on the format. First obtain the upload policy, then upload the file by using the policy, and finally call this operation to register the upload result.</para>
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
        /// <para>The honeypot image name.</para>
        /// <para>Obtain valid values by calling ListAvailableHoneypot and using the HoneypotImageName field value from the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ruoyi</para>
        /// </summary>
        [NameInMap("HoneypotImageName")]
        [Validation(Required=false)]
        public string HoneypotImageName { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
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
        /// <para>Call <a href="~~ListHoneypotNode~~">ListHoneypotNode</a> to obtain this value.
        /// Note: This parameter is required. If this parameter is not specified, the API returns InvalidParam(400). Call ListHoneypotNode to obtain a valid NodeId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cc427e14-f257-4670-9d2b-d83bbbe*****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The template prompt for the uploaded file.</para>
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
