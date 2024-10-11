// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ExtraDataSource : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>E01D574F-ABD0-4C55-A5E3-8D24FD8D42EA</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-07T13:26:29.000Z</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-07T13:26:29.000Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("Meta")]
        [Validation(Required=false)]
        public ExtraDataSourceMeta Meta { get; set; }
        public class ExtraDataSourceMeta : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Internal")]
            [Validation(Required=false)]
            public bool? Internal { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ExtraDataSource</para>
            /// </summary>
            [NameInMap("MetaType")]
            [Validation(Required=false)]
            public string MetaType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_project</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ODPS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("UpdateFrequency")]
            [Validation(Required=false)]
            public long? UpdateFrequency { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Ready 待应用；Online 已应用；Failed失败</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UserCustomDataSource、ItemCustomDataSource、BehaviorCustomDataSource、SampleCustomDataSource</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
