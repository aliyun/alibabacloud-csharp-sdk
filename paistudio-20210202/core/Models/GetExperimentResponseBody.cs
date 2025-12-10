// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetExperimentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{     &quot;nodes&quot;: [         {             &quot;id&quot;: &quot;id-4c50-1609236241393-76174&quot;,             &quot;name&quot;: &quot;读数据表&quot;,             &quot;metadata&quot;: {                 &quot;identifier&quot;: &quot;data_source&quot;,                 &quot;version&quot;: &quot;v1&quot;,                 &quot;provider&quot;: &quot;pai&quot;             },             &quot;properties&quot;: [                 {                     &quot;name&quot;: &quot;hasPartition&quot;,                     &quot;value&quot;: false                 },                 {                     &quot;name&quot;: &quot;inputTableName&quot;,                     &quot;value&quot;: &quot;pai_online_project.e_commerce_test_data&quot;                 }             ],             &quot;position&quot;: {                 &quot;x&quot;: 427,                 &quot;y&quot;: 123             }         },         {             &quot;id&quot;: &quot;id-23ce-1609236252041-30106&quot;,             &quot;name&quot;: &quot;读数据表&quot;,             &quot;metadata&quot;: {                 &quot;identifier&quot;: &quot;data_source&quot;,                 &quot;version&quot;: &quot;v1&quot;,                 &quot;provider&quot;: &quot;pai&quot;             },             &quot;properties&quot;: [                 {                     &quot;name&quot;: &quot;inputTableName&quot;,                     &quot;value&quot;: &quot;pai_online_project.e_commerce_train_data&quot;                 },                 {                     &quot;name&quot;: &quot;hasPartition&quot;,                     &quot;value&quot;: false                 }             ],             &quot;position&quot;: {                 &quot;x&quot;: 226,                 &quot;y&quot;: 127             }         },         {             &quot;id&quot;: &quot;id-97a7-1609236275421-84245&quot;,             &quot;name&quot;: &quot;DeepFM&quot;,             &quot;metadata&quot;: {                 &quot;identifier&quot;: &quot;deepfm&quot;,                 &quot;version&quot;: &quot;v1&quot;,                 &quot;provider&quot;: &quot;pai&quot;             },             &quot;properties&quot;: [                 {                     &quot;name&quot;: &quot;trainModel&quot;,                     &quot;value&quot;: &quot;train&quot;                 },                 {                     &quot;name&quot;: &quot;arn&quot;,                     &quot;value&quot;: true                 },                 {                     &quot;name&quot;: &quot;cluster&quot;,                     &quot;value&quot;: &quot;\n{\n    &quot;ps&quot;: {\n        &quot;count&quot;: 2,\n        &quot;cpu&quot;: 1000,\n        &quot;memory&quot;: 40000\n    },\n    &quot;worker&quot;: {\n        &quot;count&quot;: 8,\n        &quot;cpu&quot;: 1000,\n        &quot;memory&quot;: 40000\n    }\n}&quot;                 }             ],             &quot;position&quot;: {                 &quot;x&quot;: 323,                 &quot;y&quot;: 345             }         }     ],     &quot;edges&quot;: [         {             &quot;source&quot;: &quot;id-23ce-1609236252041-30106&quot;,             &quot;sourceAnchor&quot;: &quot;outputTable&quot;,             &quot;targetAnchor&quot;: &quot;input1TableName&quot;,             &quot;target&quot;: &quot;id-97a7-1609236275421-84245&quot;         },         {             &quot;source&quot;: &quot;id-4c50-1609236241393-76174&quot;,             &quot;sourceAnchor&quot;: &quot;outputTable&quot;,             &quot;targetAnchor&quot;: &quot;input2TableName&quot;,             &quot;target&quot;: &quot;id-97a7-1609236275421-84245&quot;         }     ],     &quot;globalParams&quot;: [],     &quot;globalSettings&quot;: []  }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1326689413376250</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Pipeline Draft Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>draft-rbvg5wzljzjhc9ks92</para>
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Pipeline Draft Name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;mlflow&quot;:{&quot;experimentId&quot;:&quot;exp-1&quot;}}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DD405810-73C9-5721-996A-EA04BCC4BBF2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PaiStudio</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23487</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
