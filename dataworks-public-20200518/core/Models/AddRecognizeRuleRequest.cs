// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class AddRecognizeRuleRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud user who creates the sensitive data identification rule. Enter the username.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsg-uat</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The column exclusion setting. The specified columns are excluded from identification.</para>
        /// <list type="bullet">
        /// <item><description>Format: ${workspace}.${table}.${column} or ${workspace}.${schema}.${table}.${column}.</description></item>
        /// <item><description>You can use the asterisk (<em>) as a wildcard. For example, default.table.column1</em> matches default.table.column10 and other column names starting with column1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default.qujian.*6</para>
        /// </summary>
        [NameInMap("ColExclude")]
        [Validation(Required=false)]
        public string ColExclude { get; set; }

        /// <summary>
        /// <para>The column scan setting. Only the specified columns are identified.</para>
        /// <list type="bullet">
        /// <item><description>Format: ${workspace}.${table}.${column} or ${workspace}.${schema}.${table}.${column}.</description></item>
        /// <item><description>You can use the asterisk (<em>) as a wildcard. For example, default.table.column1</em> matches default.table.column10 and other column names starting with column1.</description></item>
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
        /// <para>The hit threshold. If the percentage of sampled data that hits the named entity recognition (NER) model exceeds the threshold, such as 60%, the data is considered to hit the sensitive field. Valid values: an integer from 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("HitThreshold")]
        [Validation(Required=false)]
        public int? HitThreshold { get; set; }

        /// <summary>
        /// <para>The sensitivity level of the sensitive field. Select a level defined in the template for the new sensitive field, such as levels 1 to 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The name of the sensitivity level. You can call the <a href="https://help.aliyun.com/document_detail/2743948.html">QueryDefaultTemplate</a> operation to obtain the name of the selected level in the template.</para>
        /// <para>Note: This parameter is required by the current service. If it is omitted, a 400 error (InternalError.Bad.Parameters: levelName not empty) is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Confidential</para>
        /// </summary>
        [NameInMap("LevelName")]
        [Validation(Required=false)]
        public string LevelName { get; set; }

        /// <summary>
        /// <para>The classification node ID. You can call the <a href="https://help.aliyun.com/document_detail/2746850.html">QuerySensClassification</a> operation to obtain all node IDs and select a node to create a sensitive field. Enter the ID of the selected node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ce67949-0810-400f-a24a-****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The parent node information of the classification node. You can call the <a href="https://help.aliyun.com/document_detail/2746850.html">QuerySensClassification</a> operation to obtain the information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer/personal/personal_Natural _Information/personal basic_profile_information</para>
        /// </summary>
        [NameInMap("NodeParent")]
        [Validation(Required=false)]
        public string NodeParent { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: OR</description></item>
        /// <item><description>1: AND</description></item>
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
        /// <para>The content of the sensitive data identification rule. Call <a href="https://help.aliyun.com/document_detail/2747189.html">QuerySensNodeInfo</a> to see how the same field is configured in a built-in rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;contentRule&quot;:{&quot;_clazz&quot;:&quot;com.alipay.dsgclient.sdk.dsg.fastscan.engine.cond.GenderCond&quot;},&quot;_clazz&quot;:&quot;com.alipay.dsg.dal.model.RuleContent&quot;}</para>
        /// </summary>
        [NameInMap("RecognizeRules")]
        [Validation(Required=false)]
        public string RecognizeRules { get; set; }

        /// <summary>
        /// <para>The type of sensitive data identification rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: regular expression</description></item>
        /// <item><description>2: built-in rule</description></item>
        /// <item><description>3: sample library</description></item>
        /// <item><description>4: self-generated model</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecognizeRulesType")]
        [Validation(Required=false)]
        public string RecognizeRulesType { get; set; }

        /// <summary>
        /// <para>The description of the sensitive field. The value must be a string less than 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a sensitive field that identifies the name.</para>
        /// </summary>
        [NameInMap("SensitiveDescription")]
        [Validation(Required=false)]
        public string SensitiveDescription { get; set; }

        /// <summary>
        /// <para>The custom name of the sensitive field. The value must be a string less than 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("SensitiveName")]
        [Validation(Required=false)]
        public string SensitiveName { get; set; }

        /// <summary>
        /// <para>The status of the sensitive field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: draft</description></item>
        /// <item><description>1: active</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The template ID. You can call the <a href="https://help.aliyun.com/document_detail/2743948.html">QueryDefaultTemplate</a> operation to obtain the ID of the current default template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e1970541-6cf5-4d23-b101-****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The tenant ID. To obtain the tenant ID, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the Data Studio page, click the username in the upper-right corner, and choose Menu &gt; User Info.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10241024</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
