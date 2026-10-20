// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetAvailableParserTypesRequest : TeaModel {
        /// <summary>
        /// <para>The file type (extension) for which to retrieve supported parsers. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>doc</description></item>
        /// <item><description>docx</description></item>
        /// <item><description>ppt</description></item>
        /// <item><description>pptx</description></item>
        /// <item><description>xls</description></item>
        /// <item><description>xlsx</description></item>
        /// <item><description>md</description></item>
        /// <item><description>txt</description></item>
        /// <item><description>pdf</description></item>
        /// <item><description>png</description></item>
        /// <item><description>jpg</description></item>
        /// <item><description>jpeg</description></item>
        /// <item><description>bmp</description></item>
        /// <item><description>gif</description></item>
        /// <item><description>html</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pdf</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

    }

}
