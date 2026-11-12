// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLakebaseMountParameterGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the parameter template is applied. Valid values: 0: No. 1: Yes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsApply")]
        [Validation(Required=false)]
        public int? IsApply { get; set; }

        /// <summary>
        /// <para>The modification time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-10T12:00:00Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The details of the parameters in the template. An empty array is returned if no data is available.</para>
        /// </summary>
        [NameInMap("ParameterDetail")]
        [Validation(Required=false)]
        public List<DescribeLakebaseMountParameterGroupResponseBodyParameterDetail> ParameterDetail { get; set; }
        public class DescribeLakebaseMountParameterGroupResponseBodyParameterDetail : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto_increment_offset</para>
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// <para>The parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The description of the parameter template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default template</para>
        /// </summary>
        [NameInMap("ParameterGroupDesc")]
        [Validation(Required=false)]
        public string ParameterGroupDesc { get; set; }

        /// <summary>
        /// <para>The parameter template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcpg-lakebase-xxx</para>
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>The name of the parameter template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-template</para>
        /// </summary>
        [NameInMap("ParameterGroupName")]
        [Validation(Required=false)]
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// <para>The parameter templatetype. Valid values: 0: System. 1: User.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ParameterGroupType")]
        [Validation(Required=false)]
        public int? ParameterGroupType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F45FFACC-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
