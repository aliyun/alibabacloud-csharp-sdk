// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListWarehousesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of virtual warehouse instances.</para>
        /// </summary>
        [NameInMap("WarehouseList")]
        [Validation(Required=false)]
        public List<ListWarehousesResponseBodyWarehouseList> WarehouseList { get; set; }
        public class ListWarehousesResponseBodyWarehouseList : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            /// <summary>
            /// <para>The ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The memory capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public long? Mem { get; set; }

            /// <summary>
            /// <para>The name of the virtual warehouse instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyWarehouse</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of compute nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public long? NodeCount { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>kRunning</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>kSuspended</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>kInit</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>kFailed</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>kAllocating</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>kRunning</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>819A7F0F-2951-540F-BD94-6A41ECF0281F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
