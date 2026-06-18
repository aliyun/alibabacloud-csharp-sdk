// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ImportTaskNumberDatasRequest : TeaModel {
        /// <summary>
        /// <para>The data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>EXCEL</para>
        /// </description></item>
        /// <item><description><para>JSON</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>API calls currently support only the JSON data type.</para>
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
        /// <para>Importing data by specifying an OSS file path is not available because API calls currently support only the JSON data type.</para>
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
        /// <para>If <c>DataType</c> is set to <c>JSON</c>, you must use this parameter to upload the data. You can import up to 1,000 records per request.</para>
        /// </summary>
        [NameInMap("PhoneNumberList")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> PhoneNumberList { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the call task.</para>
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
