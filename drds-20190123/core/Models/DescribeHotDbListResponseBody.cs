// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeHotDbListResponseBody : TeaModel {
        /// <summary>
        /// <para>The result that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeHotDbListResponseBodyData Data { get; set; }
        public class DescribeHotDbListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the databases on which hot-spot scale-out is performed.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public DescribeHotDbListResponseBodyDataList List { get; set; }
            public class DescribeHotDbListResponseBodyDataList : TeaModel {
                [NameInMap("InstanceDb")]
                [Validation(Required=false)]
                public List<DescribeHotDbListResponseBodyDataListInstanceDb> InstanceDb { get; set; }
                public class DescribeHotDbListResponseBodyDataListInstanceDb : TeaModel {
                    [NameInMap("HotDbList")]
                    [Validation(Required=false)]
                    public DescribeHotDbListResponseBodyDataListInstanceDbHotDbList HotDbList { get; set; }
                    public class DescribeHotDbListResponseBodyDataListInstanceDbHotDbList : TeaModel {
                        [NameInMap("data")]
                        [Validation(Required=false)]
                        public List<string> Data { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>instanceName</para>
                    /// </summary>
                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                }

            }

            /// <summary>
            /// <para>The random number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jzhz</para>
            /// </summary>
            [NameInMap("RandomCode")]
            [Validation(Required=false)]
            public string RandomCode { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msg</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B6B7BDC-575D-4A77-A4F8-24B7EF******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
