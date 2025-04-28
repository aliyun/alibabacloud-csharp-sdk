// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeRdsAnalysisResourceQuotasResponseBody : TeaModel {
        /// <summary>
        /// <para>The editions of the MySQL analytic instances.</para>
        /// </summary>
        [NameInMap("DBNodeCategoryList")]
        [Validation(Required=false)]
        public DescribeRdsAnalysisResourceQuotasResponseBodyDBNodeCategoryList DBNodeCategoryList { get; set; }
        public class DescribeRdsAnalysisResourceQuotasResponseBodyDBNodeCategoryList : TeaModel {
            [NameInMap("DBNodeCategory")]
            [Validation(Required=false)]
            public List<DescribeRdsAnalysisResourceQuotasResponseBodyDBNodeCategoryListDBNodeCategory> DBNodeCategory { get; set; }
            public class DescribeRdsAnalysisResourceQuotasResponseBodyDBNodeCategoryListDBNodeCategory : TeaModel {
                /// <summary>
                /// <para>The display value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mixed_storage</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The real value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mixed_storage</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The instance types of the MySQL analytic instances.</para>
        /// </summary>
        [NameInMap("DBNodeClassList")]
        [Validation(Required=false)]
        public DescribeRdsAnalysisResourceQuotasResponseBodyDBNodeClassList DBNodeClassList { get; set; }
        public class DescribeRdsAnalysisResourceQuotasResponseBodyDBNodeClassList : TeaModel {
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public List<DescribeRdsAnalysisResourceQuotasResponseBodyDBNodeClassListDBNodeClass> DBNodeClass { get; set; }
            public class DescribeRdsAnalysisResourceQuotasResponseBodyDBNodeClassListDBNodeClass : TeaModel {
                /// <summary>
                /// <para>The display value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>E32</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The real value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>E32</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The storage sizes of the MySQL analytic instances.</para>
        /// </summary>
        [NameInMap("DBNodeStorageList")]
        [Validation(Required=false)]
        public DescribeRdsAnalysisResourceQuotasResponseBodyDBNodeStorageList DBNodeStorageList { get; set; }
        public class DescribeRdsAnalysisResourceQuotasResponseBodyDBNodeStorageList : TeaModel {
            [NameInMap("DBNodeStorage")]
            [Validation(Required=false)]
            public List<DescribeRdsAnalysisResourceQuotasResponseBodyDBNodeStorageListDBNodeStorage> DBNodeStorage { get; set; }
            public class DescribeRdsAnalysisResourceQuotasResponseBodyDBNodeStorageListDBNodeStorage : TeaModel {
                /// <summary>
                /// <para>The display value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The real value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The versions of the MySQL analytic instances.</para>
        /// </summary>
        [NameInMap("EngineVersionList")]
        [Validation(Required=false)]
        public DescribeRdsAnalysisResourceQuotasResponseBodyEngineVersionList EngineVersionList { get; set; }
        public class DescribeRdsAnalysisResourceQuotasResponseBodyEngineVersionList : TeaModel {
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public List<DescribeRdsAnalysisResourceQuotasResponseBodyEngineVersionListEngineVersion> EngineVersion { get; set; }
            public class DescribeRdsAnalysisResourceQuotasResponseBodyEngineVersionListEngineVersion : TeaModel {
                /// <summary>
                /// <para>The display value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.0</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The real value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.0</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The modes of the MySQL analytic instances.</para>
        /// </summary>
        [NameInMap("ModeList")]
        [Validation(Required=false)]
        public DescribeRdsAnalysisResourceQuotasResponseBodyModeList ModeList { get; set; }
        public class DescribeRdsAnalysisResourceQuotasResponseBodyModeList : TeaModel {
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public List<DescribeRdsAnalysisResourceQuotasResponseBodyModeListMode> Mode { get; set; }
            public class DescribeRdsAnalysisResourceQuotasResponseBodyModeListMode : TeaModel {
                /// <summary>
                /// <para>The display value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flexible</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The real value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flexible</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A31D7FA-1826-5843-8807-D2F715E70CB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The storage types of the MySQL analytic instances.</para>
        /// </summary>
        [NameInMap("StorageTypeList")]
        [Validation(Required=false)]
        public DescribeRdsAnalysisResourceQuotasResponseBodyStorageTypeList StorageTypeList { get; set; }
        public class DescribeRdsAnalysisResourceQuotasResponseBodyStorageTypeList : TeaModel {
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public List<DescribeRdsAnalysisResourceQuotasResponseBodyStorageTypeListStorageType> StorageType { get; set; }
            public class DescribeRdsAnalysisResourceQuotasResponseBodyStorageTypeListStorageType : TeaModel {
                /// <summary>
                /// <para>The display value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The real value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
