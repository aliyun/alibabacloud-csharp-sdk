// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class MetadataSchemaField : TeaModel {
        /// <summary>
        /// <para>The name of the metadata field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>department</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Valid values: STRING, LONG, DOUBLE, BOOLEAN, and DATETIME. This field is ignored when ValueMode is set to SYSTEM_VARIABLE. The system enforces the inherent type of the bound variable: DOCUMENT_NAME, FILE_TYPE, SOURCE_TYPE, and SOURCE_URI use STRING. FILE_SIZE, DOCUMENT_UPLOAD_TIME, and SOURCE_MODIFIED_TIME use LONG. An incorrect value specified by the user has no effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STRING</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>When ValueMode is set to CONSTANT, this field specifies a fixed value. An empty value indicates that the value can be assigned during document upload. When ValueMode is set to SYSTEM_VARIABLE, this field specifies a system variable name. Valid system variable names: DOCUMENT_NAME, FILE_TYPE, FILE_SIZE, DOCUMENT_UPLOAD_TIME, SOURCE_TYPE, SOURCE_URI, and SOURCE_MODIFIED_TIME. The system maintains the values of system variables. For manual uploads, the source is fixed to UPLOAD, and SOURCE_URI and SOURCE_MODIFIED_TIME use the values declared by the user. For event stream imports, the system automatically maintains the values. For example, for an OSS import, the source is OSS, SOURCE_URI is oss://bucket/key, and SOURCE_MODIFIED_TIME is the object modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EventHouse</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>This field is optional. If omitted, the user assigns the value during document upload. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CONSTANT: The field uses a constant. If Value is not empty, the fixed value is automatically applied to the document. If Value is empty, the value can be assigned during upload.</description></item>
        /// <item><description>SYSTEM_VARIABLE: The field is bound to a system variable. Value specifies the variable name, and the system automatically populates the value from the document facts.</description></item>
        /// </list>
        /// <para>A value explicitly provided by the user during document upload always takes precedence. The backend does not override user-specified values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONSTANT</para>
        /// </summary>
        [NameInMap("ValueMode")]
        [Validation(Required=false)]
        public string ValueMode { get; set; }

    }

}
