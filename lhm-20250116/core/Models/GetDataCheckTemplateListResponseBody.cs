// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetDataCheckTemplateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list returned by the operation. For the structure of each element, see the child field descriptions.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetDataCheckTemplateListResponseBodyData> Data { get; set; }
        public class GetDataCheckTemplateListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The validation rule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: data volume comparison.</description></item>
            /// <item><description>1: metric comparison.</description></item>
            /// <item><description>2: weak content comparison.</description></item>
            /// <item><description>3: custom comparison.</description></item>
            /// <item><description>4: full-text comparison.</description></item>
            /// <item><description>5: null rate comparison.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("checkType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>The display name of the check type, used in exported reports.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metric Comparison</para>
            /// </summary>
            [NameInMap("checkTypeExport")]
            [Validation(Required=false)]
            public string CheckTypeExport { get; set; }

            /// <summary>
            /// <para>The name of the check type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("checkTypeName")]
            [Validation(Required=false)]
            public int? CheckTypeName { get; set; }

            /// <summary>
            /// <para>The list of covered data source types. Multiple values are separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hive,MaxCompute</para>
            /// </summary>
            [NameInMap("dsTypes")]
            [Validation(Required=false)]
            public string DsTypes { get; set; }

            /// <summary>
            /// <para>The list of covered validation engine types, such as Tez and MapReduce. When returned as a string, multiple values are separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tez,MapReduce</para>
            /// </summary>
            [NameInMap("engineTypes")]
            [Validation(Required=false)]
            public string EngineTypes { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16 10:00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Specifies whether the template is built-in. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No. The template is a custom template.</description></item>
            /// <item><description>1: Yes. The template is a built-in template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isBuiltin")]
            [Validation(Required=false)]
            public int? IsBuiltin { get; set; }

            /// <summary>
            /// <para>Indicates whether the template is referenced by a validation task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The template is referenced.</description></item>
            /// <item><description>false: The template is not referenced.
            /// The delete operation does not verify this reference relationship. Confirm before deleting.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("isUsedByTask")]
            [Validation(Required=false)]
            public bool? IsUsedByTask { get; set; }

            /// <summary>
            /// <para>The template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description of the data volume validation template</para>
            /// </summary>
            [NameInMap("templateDesc")]
            [Validation(Required=false)]
            public string TemplateDesc { get; set; }

            /// <summary>
            /// <para>The validation template ID (logical foreign key) that uniquely identifies a validation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the validation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataVolumeValidationTemplate</para>
            /// </summary>
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The error code. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call failed. Check errCode and errMessage for details.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
