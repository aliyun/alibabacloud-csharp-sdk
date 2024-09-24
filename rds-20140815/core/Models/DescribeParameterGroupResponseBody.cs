// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeParameterGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the parameter template.</para>
        /// </summary>
        [NameInMap("ParamGroup")]
        [Validation(Required=false)]
        public DescribeParameterGroupResponseBodyParamGroup ParamGroup { get; set; }
        public class DescribeParameterGroupResponseBodyParamGroup : TeaModel {
            [NameInMap("ParameterGroup")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupResponseBodyParamGroupParameterGroup> ParameterGroup { get; set; }
            public class DescribeParameterGroupResponseBodyParamGroupParameterGroup : TeaModel {
                /// <summary>
                /// <para>The time when the parameter template was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-10-22T06:02:53Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The database engine of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The database engine version of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.6</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the restart of an instance is required for the parameter template to take effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: A restart is not required.</description></item>
                /// <item><description><b>1</b>: A restart is required.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public int? ForceRestart { get; set; }

                /// <summary>
                /// <para>The number of parameters in the parameter template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ParamCounts")]
                [Validation(Required=false)]
                public int? ParamCounts { get; set; }

                /// <summary>
                /// <para>The details of the parameters.</para>
                /// </summary>
                [NameInMap("ParamDetail")]
                [Validation(Required=false)]
                public DescribeParameterGroupResponseBodyParamGroupParameterGroupParamDetail ParamDetail { get; set; }
                public class DescribeParameterGroupResponseBodyParamGroupParameterGroupParamDetail : TeaModel {
                    [NameInMap("ParameterDetail")]
                    [Validation(Required=false)]
                    public List<DescribeParameterGroupResponseBodyParamGroupParameterGroupParamDetailParameterDetail> ParameterDetail { get; set; }
                    public class DescribeParameterGroupResponseBodyParamGroupParameterGroupParamDetailParameterDetail : TeaModel {
                        /// <summary>
                        /// <para>The name of the parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>back_log</para>
                        /// </summary>
                        [NameInMap("ParamName")]
                        [Validation(Required=false)]
                        public string ParamName { get; set; }

                        /// <summary>
                        /// <para>The value of the parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2000</para>
                        /// </summary>
                        [NameInMap("ParamValue")]
                        [Validation(Required=false)]
                        public string ParamValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The description of the parameter template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testGroup1</para>
                /// </summary>
                [NameInMap("ParameterGroupDesc")]
                [Validation(Required=false)]
                public string ParameterGroupDesc { get; set; }

                /// <summary>
                /// <para>The ID of the parameter template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rpg-dp****</para>
                /// </summary>
                [NameInMap("ParameterGroupId")]
                [Validation(Required=false)]
                public string ParameterGroupId { get; set; }

                /// <summary>
                /// <para>The name of the parameter template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123456</para>
                /// </summary>
                [NameInMap("ParameterGroupName")]
                [Validation(Required=false)]
                public string ParameterGroupName { get; set; }

                /// <summary>
                /// <para>The type of the parameter template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: the default parameter template.</description></item>
                /// <item><description><b>1</b>: a custom parameter template.</description></item>
                /// <item><description><b>2</b>: an automatic backup parameter template. After you apply this type of template, the system automatically backs up the original parameter settings and saves the backup as a template.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParameterGroupType")]
                [Validation(Required=false)]
                public int? ParameterGroupType { get; set; }

                /// <summary>
                /// <para>The time when the parameter template was last updated. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-10-22T06:07:54Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The information about the instance to which the parameter template is applied.</para>
        /// <remarks>
        /// <para> This parameter is available only for ApsaraDB RDS for PostgreSQL instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RelatedCustinsInfo")]
        [Validation(Required=false)]
        public DescribeParameterGroupResponseBodyRelatedCustinsInfo RelatedCustinsInfo { get; set; }
        public class DescribeParameterGroupResponseBodyRelatedCustinsInfo : TeaModel {
            [NameInMap("RelatedCustinsInfo")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupResponseBodyRelatedCustinsInfoRelatedCustinsInfo> RelatedCustinsInfo { get; set; }
            public class DescribeParameterGroupResponseBodyRelatedCustinsInfoRelatedCustinsInfo : TeaModel {
                /// <summary>
                /// <para>The time when the parameter template was applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-17T03:19:02Z</para>
                /// </summary>
                [NameInMap("AppliedTime")]
                [Validation(Required=false)]
                public string AppliedTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp170****</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>498AE8CA-8C81-4A01-AF37-2B902014ED30</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
