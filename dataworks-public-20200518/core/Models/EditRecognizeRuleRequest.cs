// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class EditRecognizeRuleRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud account that is used to create the sensitive data identification rule. Enter the username of the Alibaba Cloud account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Excludes fields. The system does not identify fields that are assigned with values.
        /// 
        /// *   The value must be in the ${Project name}.${Table name}.${Field name} or ${Project name}.${Schema name}.${Table name}.${Field name} format.
        /// *   *Wildcards are supported. For example, the asterisk (\\*) in default.table.column1\\* can be used to match any content following default.table.column1, such as default.table.column10.
        /// </summary>
        [NameInMap("ColExclude")]
        [Validation(Required=false)]
        public string ColExclude { get; set; }

        /// <summary>
        /// Scans fields. The system identifies only fields that are assigned with values.
        /// 
        /// *   The value must be in the ${Project name}.${Table name}.${Field name} or ${Project name}.${Schema name}.${Table name}.${Field name} format.
        /// *   *Wildcards are supported. For example, the asterisk (\\*) in default.table.column1\\* can be used to match any content following default.table.column1, such as default.table.column10.
        /// </summary>
        [NameInMap("ColScan")]
        [Validation(Required=false)]
        public string ColScan { get; set; }

        /// <summary>
        /// Scans content. The value is the text of each field comment in your data asset. Fuzzy match is supported.
        /// </summary>
        [NameInMap("CommentScan")]
        [Validation(Required=false)]
        public string CommentScan { get; set; }

        /// <summary>
        /// Identifies content. You can call the [QuerySensNodeInfo](https://help.aliyun.com/document_detail/2747189.html) operation to query the value of the current parameter for a built-in sensitive field.
        /// </summary>
        [NameInMap("ContentScan")]
        [Validation(Required=false)]
        public string ContentScan { get; set; }

        /// <summary>
        /// The hit ratio threshold. If more than 60%, which is a sample hit ratio threshold, of all sample data records hit the Name Entity Recognition (NER) model, the sensitive field is hit. The value can be an integer from 0 to 100.
        /// </summary>
        [NameInMap("HitThreshold")]
        [Validation(Required=false)]
        public int? HitThreshold { get; set; }

        /// <summary>
        /// The name of the sensitivity level. You can call the [QueryDefaultTemplate](https://help.aliyun.com/document_detail/2743948.html) operation to obtain the name of the sensitivity level in the related template.
        /// </summary>
        [NameInMap("LevelName")]
        [Validation(Required=false)]
        public string LevelName { get; set; }

        /// <summary>
        /// The ID of the data category. You can call the [QuerySensClassification](https://help.aliyun.com/document_detail/2746850.html) operation to query the ID of all data categories. Then, you can select a data category to create a sensitive field. Enter the ID of the selected data category.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The information about the parent data category of the current data category. You can call the [QuerySensClassification](https://help.aliyun.com/document_detail/2746850.html) operation to obtain the ID of a data category.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeParent")]
        [Validation(Required=false)]
        public string NodeParent { get; set; }

        /// <summary>
        /// The type of the arithmetic operation. Valid values:
        /// 
        /// *   0: OR
        /// *   1: AND
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public int? OperationType { get; set; }

        /// <summary>
        /// The content of the sensitive data identification rule. You can call the [QuerySensNodeInfo](https://help.aliyun.com/document_detail/2747189.html) operation to query the value of the current parameter for a built-in sensitive field.
        /// </summary>
        [NameInMap("RecognizeRules")]
        [Validation(Required=false)]
        public string RecognizeRules { get; set; }

        /// <summary>
        /// The type of the sensitive data identification rule. Valid values:
        /// 
        /// *   1: regular expression
        /// *   2: built-in rule
        /// *   3: sample library
        /// *   4: self-generated data identification model
        /// </summary>
        [NameInMap("RecognizeRulesType")]
        [Validation(Required=false)]
        public string RecognizeRulesType { get; set; }

        /// <summary>
        /// The description of the sensitive field. Enter a string that is less than 128 characters in length.
        /// </summary>
        [NameInMap("SensitiveDescription")]
        [Validation(Required=false)]
        public string SensitiveDescription { get; set; }

        /// <summary>
        /// The sensitive field ID. You can call the [QuerySensNodeInfo](https://help.aliyun.com/document_detail/2747189.html) operation to query the IDs of all sensitive fields. You can also call the [QueryRecognizeRuleDetail](https://help.aliyun.com/document_detail/2766023.html) operation to query the IDs of specific sensitive fields.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SensitiveId")]
        [Validation(Required=false)]
        public string SensitiveId { get; set; }

        /// <summary>
        /// The name of the custom sensitive field. Enter a string that is less than 128 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SensitiveName")]
        [Validation(Required=false)]
        public string SensitiveName { get; set; }

        /// <summary>
        /// The status of the sensitive field. Valid values:
        /// 
        /// *   0: draft
        /// *   1: effective
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The template ID. You can call the [QueryDefaultTemplate](https://help.aliyun.com/document_detail/2743948.html) operation to obtain the template ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The tenant ID. To obtain the tenant ID, perform the following steps: Log on to the [DataWorks console](https://workbench.data.aliyun.com/console). Find your workspace and go to the DataStudio page. On the DataStudio page, click the logon username in the upper-right corner and click User Info in the Menu section.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The sensitivity level of the sensitive field. You can select one from all sensitivity levels that are defined in a template as the sensitivity level of the sensitive field, such as level 1 to level 10.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

    }

}
