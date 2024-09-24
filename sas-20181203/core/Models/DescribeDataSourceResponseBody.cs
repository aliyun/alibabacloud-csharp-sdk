// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDataSourceResponseBody : TeaModel {
        [NameInMap("MetaDatas")]
        [Validation(Required=false)]
        public List<DescribeDataSourceResponseBodyMetaDatas> MetaDatas { get; set; }
        public class DescribeDataSourceResponseBodyMetaDatas : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1753</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public int? DataSourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sas_analysis_pre-sas-operation-log-sas-event-suspicious</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingtalk_suspicious</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("MetaDataFields")]
            [Validation(Required=false)]
            public List<DescribeDataSourceResponseBodyMetaDatasMetaDataFields> MetaDataFields { get; set; }
            public class DescribeDataSourceResponseBodyMetaDatasMetaDataFields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>type</para>
                /// </summary>
                [NameInMap("Filed")]
                [Validation(Required=false)]
                public string Filed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dingtalk_vul_type</para>
                /// </summary>
                [NameInMap("FiledName")]
                [Validation(Required=false)]
                public string FiledName { get; set; }

                [NameInMap("OperatorList")]
                [Validation(Required=false)]
                public List<DescribeDataSourceResponseBodyMetaDatasMetaDataFieldsOperatorList> OperatorList { get; set; }
                public class DescribeDataSourceResponseBodyMetaDatasMetaDataFieldsOperatorList : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>regex</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>all:dingtalk_all;cms:dingtalk_vul_cms;oval:dingtalk_vul_cve;sys:dingtalk_vul_sys;emg:dingtalk_vul_emg</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DDXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
