// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata of the data sources.</para>
        /// </summary>
        [NameInMap("MetaDatas")]
        [Validation(Required=false)]
        public List<DescribeDataSourceResponseBodyMetaDatas> MetaDatas { get; set; }
        public class DescribeDataSourceResponseBodyMetaDatas : TeaModel {
            /// <summary>
            /// <para>The ID of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1753</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public int? DataSourceId { get; set; }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas_analysis_pre-sas-operation-log-sas-event-suspicious</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>The description of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk_suspicious</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The metadata files.</para>
            /// </summary>
            [NameInMap("MetaDataFields")]
            [Validation(Required=false)]
            public List<DescribeDataSourceResponseBodyMetaDatasMetaDataFields> MetaDataFields { get; set; }
            public class DescribeDataSourceResponseBodyMetaDatasMetaDataFields : TeaModel {
                /// <summary>
                /// <para>The key of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>type</para>
                /// </summary>
                [NameInMap("Filed")]
                [Validation(Required=false)]
                public string Filed { get; set; }

                /// <summary>
                /// <para>The name of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingtalk_vul_type</para>
                /// </summary>
                [NameInMap("FiledName")]
                [Validation(Required=false)]
                public string FiledName { get; set; }

                /// <summary>
                /// <para>The operators.</para>
                /// </summary>
                [NameInMap("OperatorList")]
                [Validation(Required=false)]
                public List<DescribeDataSourceResponseBodyMetaDatasMetaDataFieldsOperatorList> OperatorList { get; set; }
                public class DescribeDataSourceResponseBodyMetaDatasMetaDataFieldsOperatorList : TeaModel {
                    /// <summary>
                    /// <para>The description of the operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dingtalk_vul</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>regex</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The sample field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all:dingtalk_all;cms:dingtalk_vul_cms;oval:dingtalk_vul_cve;sys:dingtalk_vul_sys;emg:dingtalk_vul_emg</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                /// <summary>
                /// <para>The value type of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DDXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
