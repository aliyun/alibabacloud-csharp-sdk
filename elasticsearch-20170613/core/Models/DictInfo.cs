// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DictInfo : TeaModel {
        /// <summary>
        /// <para>The size of the dictionary file. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2782602</para>
        /// </summary>
        [NameInMap("fileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>The name of the dictionary file. Requirements:</para>
        /// <list type="bullet">
        /// <item><description>Main dictionary or stopword list: one word per line, saved as a UTF-8 encoded DIC file. The file name can contain uppercase and lowercase letters, digits, and underscores, and cannot exceed 30 characters in length. Files with duplicate names are not allowed. The main dictionary file and the stopword file cannot share the same name.</description></item>
        /// <item><description>Synonym dictionary: one synonym expression per line, saved as a UTF-8 encoded TXT file.</description></item>
        /// <item><description>Alibaba dictionary: the file name must be aliws_ext_dict.txt. The file must be in UTF-8 format. Each line contains one word with no leading or trailing whitespace. Use UNIX or Linux line endings, where each line ends with 
        /// . If the file is generated on a Windows system, use the dos2unix tool on a Linux machine to process the dictionary file before uploading it.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliws_ext_dict.txt</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The source type of the dictionary file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS: Object Storage Service (OSS). Ensure that the OSS bucket has public-read permission.</description></item>
        /// <item><description>ORIGIN: open-source Elasticsearch</description></item>
        /// <item><description>UPLOAD: uploaded file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The type of the dictionary file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>STOP: stopword list</description></item>
        /// <item><description>MAIN: main dictionary</description></item>
        /// <item><description>SYNONYMS: synonym dictionary</description></item>
        /// <item><description>ALI_WS: Alibaba dictionary.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALI_WS</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
