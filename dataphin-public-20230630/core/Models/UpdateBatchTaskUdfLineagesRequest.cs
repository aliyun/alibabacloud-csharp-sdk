// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateBatchTaskUdfLineagesRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateBatchTaskUdfLineagesRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateBatchTaskUdfLineagesRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The node ID in the task directory tree.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12113111</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>The list of lineage groups.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("LineageGroupList")]
            [Validation(Required=false)]
            public List<UpdateBatchTaskUdfLineagesRequestUpdateCommandLineageGroupList> LineageGroupList { get; set; }
            public class UpdateBatchTaskUdfLineagesRequestUpdateCommandLineageGroupList : TeaModel {
                /// <summary>
                /// <para>The collection of input tables for lineage.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("InputLineageList")]
                [Validation(Required=false)]
                public List<UpdateBatchTaskUdfLineagesRequestUpdateCommandLineageGroupListInputLineageList> InputLineageList { get; set; }
                public class UpdateBatchTaskUdfLineagesRequestUpdateCommandLineageGroupListInputLineageList : TeaModel {
                    /// <summary>
                    /// <para>The list of lineage columns.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("ColumnList")]
                    [Validation(Required=false)]
                    public List<string> ColumnList { get; set; }

                    /// <summary>
                    /// <para>The environment. Valid values: prod, dev, and auto.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dev</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to select the full table.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("FullTable")]
                    [Validation(Required=false)]
                    public bool? FullTable { get; set; }

                    /// <summary>
                    /// <para>The name of the table.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>t_input</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The collection of output tables for lineage.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("OutputLineageList")]
                [Validation(Required=false)]
                public List<UpdateBatchTaskUdfLineagesRequestUpdateCommandLineageGroupListOutputLineageList> OutputLineageList { get; set; }
                public class UpdateBatchTaskUdfLineagesRequestUpdateCommandLineageGroupListOutputLineageList : TeaModel {
                    /// <summary>
                    /// <para>The list of lineage columns.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("ColumnList")]
                    [Validation(Required=false)]
                    public List<string> ColumnList { get; set; }

                    /// <summary>
                    /// <para>The environment. Valid values: prod, dev, and auto.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dev</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to select the full table.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("FullTable")]
                    [Validation(Required=false)]
                    public bool? FullTable { get; set; }

                    /// <summary>
                    /// <para>The name of the table.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>t_output</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The project to which the task belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131211211</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

    }

}
