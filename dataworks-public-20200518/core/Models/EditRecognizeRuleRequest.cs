// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class EditRecognizeRuleRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account that is used to create the sensitive data identification rule. Enter the username of the Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsg-uat</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>Excludes fields. The system does not identify fields that are assigned with values.</para>
        /// <list type="bullet">
        /// <item><description>The value must be in the ${Project name}.${Table name}.${Field name} or ${Project name}.${Schema name}.${Table name}.${Field name} format.</description></item>
        /// <item><description><em>Wildcards are supported. For example, the asterisk (\</em>) in default.table.column1\* can be used to match any content following default.table.column1, such as default.table.column10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default.qujian.*6</para>
        /// </summary>
        [NameInMap("ColExclude")]
        [Validation(Required=false)]
        public string ColExclude { get; set; }

        /// <summary>
        /// <para>Scans fields. The system identifies only fields that are assigned with values.</para>
        /// <list type="bullet">
        /// <item><description>The value must be in the ${Project name}.${Table name}.${Field name} or ${Project name}.${Schema name}.${Table name}.${Field name} format.</description></item>
        /// <item><description><em>Wildcards are supported. For example, the asterisk (\</em>) in default.table.column1\* can be used to match any content following default.table.column1, such as default.table.column10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default.qujian.*</para>
        /// </summary>
        [NameInMap("ColScan")]
        [Validation(Required=false)]
        public string ColScan { get; set; }

        /// <summary>
        /// <para>Scans content. The value is the text of each field comment in your data asset. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("CommentScan")]
        [Validation(Required=false)]
        public string CommentScan { get; set; }

        /// <summary>
        /// <para>Identifies content. You can call the <a href="https://help.aliyun.com/document_detail/2747189.html">QuerySensNodeInfo</a> operation to query the value of the current parameter for a built-in sensitive field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;_clazz&quot;:&quot;com.alipay.dsgclient.sdk.dsg.fastscan.engine.cond.NationalityCond&quot;}</para>
        /// </summary>
        [NameInMap("ContentScan")]
        [Validation(Required=false)]
        public string ContentScan { get; set; }

        /// <summary>
        /// <para>The hit ratio threshold. If more than 60%, which is a sample hit ratio threshold, of all sample data records hit the Name Entity Recognition (NER) model, the sensitive field is hit. The value can be an integer from 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("HitThreshold")]
        [Validation(Required=false)]
        public int? HitThreshold { get; set; }

        /// <summary>
        /// <para>The name of the sensitivity level. You can call the <a href="https://help.aliyun.com/document_detail/2743948.html">QueryDefaultTemplate</a> operation to obtain the name of the sensitivity level in the related template.</para>
        /// </summary>
        [NameInMap("LevelName")]
        [Validation(Required=false)]
        public string LevelName { get; set; }

        /// <summary>
        /// <para>The ID of the data category. You can call the <a href="https://help.aliyun.com/document_detail/2746850.html">QuerySensClassification</a> operation to query the ID of all data categories. Then, you can select a data category to create a sensitive field. Enter the ID of the selected data category.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ce67949-0810-400f-a24a-cc5ffafe1024</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The information about the parent data category of the current data category. You can call the <a href="https://help.aliyun.com/document_detail/2746850.html">QuerySensClassification</a> operation to obtain the ID of a data category.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeParent")]
        [Validation(Required=false)]
        public string NodeParent { get; set; }

        /// <summary>
        /// <para>The type of the arithmetic operation. Valid values:</para>
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
        /// <para>The content of the sensitive data identification rule. You can call the <a href="https://help.aliyun.com/document_detail/2747189.html">QuerySensNodeInfo</a> operation to query the value of the current parameter for a built-in sensitive field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;contentRule&quot;:{&quot;_clazz&quot;:&quot;com.alipay.dsgclient.sdk.dsg.fastscan.engine.cond.GenderCond&quot;},&quot;_clazz&quot;:&quot;com.alipay.dsg.dal.model.RuleContent&quot;}</para>
        /// </summary>
        [NameInMap("RecognizeRules")]
        [Validation(Required=false)]
        public string RecognizeRules { get; set; }

        /// <summary>
        /// <para>The type of the sensitive data identification rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: regular expression</description></item>
        /// <item><description>2: built-in rule</description></item>
        /// <item><description>3: sample library</description></item>
        /// <item><description>4: self-generated data identification model</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecognizeRulesType")]
        [Validation(Required=false)]
        public string RecognizeRulesType { get; set; }

        /// <summary>
        /// <para>The description of the sensitive field. Enter a string that is less than 128 characters in length.</para>
        /// </summary>
        [NameInMap("SensitiveDescription")]
        [Validation(Required=false)]
        public string SensitiveDescription { get; set; }

        /// <summary>
        /// <para>The sensitive field ID. You can call the <a href="https://help.aliyun.com/document_detail/2747189.html">QuerySensNodeInfo</a> operation to query the IDs of all sensitive fields. You can also call the <a href="https://help.aliyun.com/document_detail/2766023.html">QueryRecognizeRuleDetail</a> operation to query the IDs of specific sensitive fields.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a928de7-3962-4e07-93ac-e1973baa1024</para>
        /// </summary>
        [NameInMap("SensitiveId")]
        [Validation(Required=false)]
        public string SensitiveId { get; set; }

        /// <summary>
        /// <para>The name of the custom sensitive field. Enter a string that is less than 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SensitiveName")]
        [Validation(Required=false)]
        public string SensitiveName { get; set; }

        /// <summary>
        /// <para>The status of the sensitive field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: draft</description></item>
        /// <item><description>1: effective</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The template ID. You can call the <a href="https://help.aliyun.com/document_detail/2743948.html">QueryDefaultTemplate</a> operation to obtain the template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e1970541-6cf5-4d23-b101-d5b66f6e1024</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The tenant ID. To obtain the tenant ID, perform the following steps: Log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. Find your workspace and go to the DataStudio page. On the DataStudio page, click the logon username in the upper-right corner and click User Info in the Menu section.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10241024</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The sensitivity level of the sensitive field. You can select one from all sensitivity levels that are defined in a template as the sensitivity level of the sensitive field, such as level 1 to level 10.</para>
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
