// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>This is a test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FeatureEntityCount")]
        [Validation(Required=false)]
        public int? FeatureEntityCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FeatureViewCount")]
        [Validation(Required=false)]
        public int? FeatureViewCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ModelCount")]
        [Validation(Required=false)]
        public int? ModelCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>project1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("OfflineDatasourceId")]
        [Validation(Required=false)]
        public string OfflineDatasourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>datasource1</para>
        /// </summary>
        [NameInMap("OfflineDatasourceName")]
        [Validation(Required=false)]
        public string OfflineDatasourceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("OfflineDatasourceType")]
        [Validation(Required=false)]
        public string OfflineDatasourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("OfflineLifecycle")]
        [Validation(Required=false)]
        public int? OfflineLifecycle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("OnlineDatasourceId")]
        [Validation(Required=false)]
        public string OnlineDatasourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>datasource2</para>
        /// </summary>
        [NameInMap("OnlineDatasourceName")]
        [Validation(Required=false)]
        public string OnlineDatasourceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Hologres</para>
        /// </summary>
        [NameInMap("OnlineDatasourceType")]
        [Validation(Required=false)]
        public string OnlineDatasourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1232132543543****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C33E160C-BFCA-5719-B958-942850E949F6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
