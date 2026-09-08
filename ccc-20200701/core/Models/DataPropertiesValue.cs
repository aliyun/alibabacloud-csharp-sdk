// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class DataPropertiesValue : TeaModel {
        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>姓名</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The regular expression that is used for validation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>^</para>
        /// </summary>
        [NameInMap("Pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// <para>The error message that is returned if the value does not match the regular expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>不是有效的email地址</para>
        /// </summary>
        [NameInMap("PatternErrorMessage")]
        [Validation(Required=false)]
        public string PatternErrorMessage { get; set; }

        /// <summary>
        /// <para>The minimum length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinLength")]
        [Validation(Required=false)]
        public int? MinLength { get; set; }

        /// <summary>
        /// <para>The maximum length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxLength")]
        [Validation(Required=false)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// <para>The minimum value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Minimum")]
        [Validation(Required=false)]
        public double? Minimum { get; set; }

        /// <summary>
        /// <para>The maximum value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Maximum")]
        [Validation(Required=false)]
        public double? Maximum { get; set; }

        /// <summary>
        /// <para>Indicates whether the field is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// <para>Indicates whether the field is a system field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("System")]
        [Validation(Required=false)]
        public bool? System { get; set; }

        /// <summary>
        /// <para>Indicates whether the field is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>Indicates whether the field is an array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Array")]
        [Validation(Required=false)]
        public bool? Array { get; set; }

        /// <summary>
        /// <para>Indicates whether the field is read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ReadOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// <para>The type of the editor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>textbox</para>
        /// </summary>
        [NameInMap("EditorType")]
        [Validation(Required=false)]
        public string EditorType { get; set; }

        /// <summary>
        /// <para>The extended properties.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        /// <summary>
        /// <para>The display order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DisplayOrder")]
        [Validation(Required=false)]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// <para>The time when the field was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-14 10:48:43.0</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// <para>The time when the field was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-14 10:48:43.0</para>
        /// </summary>
        [NameInMap("UpdatedTime")]
        [Validation(Required=false)]
        public long? UpdatedTime { get; set; }

        /// <summary>
        /// <para>Creator</para>
        /// 
        /// <b>Example:</b>
        /// <para>tom</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

    }

}
