// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ImportTaskNumberDatasShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EXCEL</description></item>
        /// <item><description>JSON<remarks>
        /// <para>Notice: API calls currently support only the JSON data type.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public long? EncryptionType { get; set; }

        /// <summary>
        /// <para>The OSS file path. This parameter is optional.</para>
        /// <remarks>
        /// <para>API calls do not currently support the Excel data type. Therefore, uploading an OSS file path is currently unavailable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123dsdfsdfsdf.xlsx</para>
        /// </summary>
        [NameInMap("OssFileName")]
        [Validation(Required=false)]
        public string OssFileName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>If DataType is set to JSON, upload data through this field. A maximum of 1000 records can be uploaded at a time.</para>
        /// </summary>
        [NameInMap("PhoneNumberList")]
        [Validation(Required=false)]
        public string PhoneNumberListShrink { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>119181071278******</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
