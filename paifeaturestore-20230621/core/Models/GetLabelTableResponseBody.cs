// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetLabelTableResponseBody : TeaModel {
        /// <summary>
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasourceId")]
        [Validation(Required=false)]
        public string DatasourceId { get; set; }

        /// <summary>
        /// <para>The data source name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>datasource1</para>
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// <para>The fields in the label table.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<GetLabelTableResponseBodyFields> Fields { get; set; }
        public class GetLabelTableResponseBodyFields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>item</para>
            /// </summary>
            [NameInMap("AlignedEntityName")]
            [Validation(Required=false)]
            public string AlignedEntityName { get; set; }

            /// <summary>
            /// <para>A list of field attributes.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            /// <summary>
            /// <para>The field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>field1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The field type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INT32</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The time when the label table was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the label table was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The label table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>label_table1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12321312*****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project1</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>A list of related model feature names.</para>
        /// </summary>
        [NameInMap("RelatedModelFeatures")]
        [Validation(Required=false)]
        public List<string> RelatedModelFeatures { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
