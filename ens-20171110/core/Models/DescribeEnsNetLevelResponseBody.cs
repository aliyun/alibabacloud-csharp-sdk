// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetLevelResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned service code. A value of 0 indicates that the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The network levels.</para>
        /// </summary>
        [NameInMap("EnsNetLevels")]
        [Validation(Required=false)]
        public DescribeEnsNetLevelResponseBodyEnsNetLevels EnsNetLevels { get; set; }
        public class DescribeEnsNetLevelResponseBodyEnsNetLevels : TeaModel {
            [NameInMap("EnsNetLevel")]
            [Validation(Required=false)]
            public List<DescribeEnsNetLevelResponseBodyEnsNetLevelsEnsNetLevel> EnsNetLevel { get; set; }
            public class DescribeEnsNetLevelResponseBodyEnsNetLevelsEnsNetLevel : TeaModel {
                /// <summary>
                /// <para>The network level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Big: greater area.</description></item>
                /// <item><description>Middle: province.</description></item>
                /// <item><description>Small: city.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Big</para>
                /// </summary>
                [NameInMap("EnsNetLevelCode")]
                [Validation(Required=false)]
                public string EnsNetLevelCode { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86A6D421-A0C7-4C01-8648-47377CA6A2CE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
