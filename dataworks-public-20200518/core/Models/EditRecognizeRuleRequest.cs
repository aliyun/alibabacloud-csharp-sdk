// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class EditRecognizeRuleRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud user that creates the sensitive data recognition rule. Enter the username.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsg-uat</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The field exclusion configuration. Assigned fields are not recognized.</para>
        /// <list type="bullet">
        /// <item><description>Value format: ${Workspace}.${Table}.${Field} or ${Workspace}.${Schema}.${Table}.${Field}.</description></item>
        /// <item><description>The asterisk (<em>) wildcard is supported. For example, default.table.column1</em> can match any content after the asterisk, such as default.table.column10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default.qujian.*6</para>
        /// </summary>
        [NameInMap("ColExclude")]
        [Validation(Required=false)]
        public string ColExclude { get; set; }

        /// <summary>
        /// <para>The field scanning configuration. Only assigned fields are recognized.</para>
        /// <list type="bullet">
        /// <item><description>Value format: ${Workspace}.${Table}.${Field} or ${Workspace}.${Schema}.${Table}.${Field}.</description></item>
        /// <item><description>The asterisk (<em>) wildcard is supported. For example, default.table.column1</em> can match any content after the asterisk, such as default.table.column10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default.qujian.*</para>
        /// </summary>
        [NameInMap("ColScan")]
        [Validation(Required=false)]
        public string ColScan { get; set; }

        /// <summary>
        /// <para>The comment scanning configuration. The value is the text of the comment for each field in your data assets. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("CommentScan")]
        [Validation(Required=false)]
        public string CommentScan { get; set; }

        /// <summary>
        /// <para>The content recognition configuration. You can call the <a href="https://help.aliyun.com/document_detail/2747189.html">QuerySensNodeInfo</a> operation and refer to the configuration of the same field in the built-in rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;_clazz&quot;:&quot;com.alipay.dsgclient.sdk.dsg.fastscan.engine.cond.NationalityCond&quot;}</para>
        /// </summary>
        [NameInMap("ContentScan")]
        [Validation(Required=false)]
        public string ContentScan { get; set; }

        /// <summary>
        /// <para>The hit threshold. If the percentage of sampled data that hits the named entity recognition (NER) model exceeds the threshold (for example, 60%), the sensitive field is considered hit. Valid values: integers from 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("HitThreshold")]
        [Validation(Required=false)]
        public int? HitThreshold { get; set; }

        /// <summary>
        /// <para>The level name. You can call the <a href="https://help.aliyun.com/document_detail/2743948.html">QueryDefaultTemplate</a> operation to obtain the level name corresponding to the selected level in the template.</para>
        /// <para>Note: This parameter is actually required by the current service. If it is omitted, a 400 error (InternalError.Bad.Parameters: levelName not empty) is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Confidential</para>
        /// </summary>
        [NameInMap("LevelName")]
        [Validation(Required=false)]
        public string LevelName { get; set; }

        /// <summary>
        /// <para>The ID of the classification node. You can call the <a href="https://help.aliyun.com/document_detail/2746850.html">QuerySensClassification</a> operation to obtain all node IDs and select a node to create a sensitive field. Enter the ID of the selected node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ce67949-0810-400f-a24a-cc5ffafe1024</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The parent node information of the classification node. You can call the <a href="https://help.aliyun.com/document_detail/2746850.html">QuerySensClassification</a> operation to obtain the information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer/personal/personal_Natural_Information/personal_basic_profile_information</para>
        /// </summary>
        [NameInMap("NodeParent")]
        [Validation(Required=false)]
        public string NodeParent { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: OR.</description></item>
        /// <item><description>1: AND.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public int? OperationType { get; set; }

        /// <summary>
        /// <para>The content of the sensitive data recognition rule. You can call the <a href="https://help.aliyun.com/document_detail/2747189.html">QuerySensNodeInfo</a> operation and refer to the configuration of the same field in the built-in rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;contentRule&quot;:{&quot;_clazz&quot;:&quot;com.alipay.dsgclient.sdk.dsg.fastscan.engine.cond.GenderCond&quot;},&quot;_clazz&quot;:&quot;com.alipay.dsg.dal.model.RuleContent&quot;}</para>
        /// </summary>
        [NameInMap("RecognizeRules")]
        [Validation(Required=false)]
        public string RecognizeRules { get; set; }

        /// <summary>
        /// <para>The type of the sensitive data recognition rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Regular expression.</description></item>
        /// <item><description>2: Built-in rule.</description></item>
        /// <item><description>3: Sample library.</description></item>
        /// <item><description>4: Self-generated model.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecognizeRulesType")]
        [Validation(Required=false)]
        public string RecognizeRulesType { get; set; }

        /// <summary>
        /// <para>The description of the sensitive field. The value must be a string that is less than 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a sensitive field that identifies the name.</para>
        /// </summary>
        [NameInMap("SensitiveDescription")]
        [Validation(Required=false)]
        public string SensitiveDescription { get; set; }

        /// <summary>
        /// <para>The ID of the sensitive field. You can call the <a href="https://help.aliyun.com/document_detail/2747189.html">QuerySensNodeInfo</a> operation to obtain all sensitive field IDs, or call the <a href="https://help.aliyun.com/document_detail/2766023.html">QueryRecognizeRuleDetail</a> operation to query a specific sensitive field ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a928de7-3962-4e07-93ac-e1973baa1024</para>
        /// </summary>
        [NameInMap("SensitiveId")]
        [Validation(Required=false)]
        public string SensitiveId { get; set; }

        /// <summary>
        /// <para>The custom name of the sensitive field. Enter a string that is less than 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("SensitiveName")]
        [Validation(Required=false)]
        public string SensitiveName { get; set; }

        /// <summary>
        /// <para>The effective status of the sensitive field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Draft.</description></item>
        /// <item><description>1: Effective.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The template ID. You can call the <a href="https://help.aliyun.com/document_detail/2743948.html">QueryDefaultTemplate</a> operation to obtain the current default template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e1970541-6cf5-4d23-b101-d5b66f6e1024</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the Data Studio page, click the current username in the upper-right corner, and choose Menu &gt; User Information to obtain the tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102410000</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The level of the sensitive field. Select a level defined in the template as the level of the sensitive field. For example, levels 1 to 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

    }

}
