// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeEvaluateAndImportTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEvaluateAndImportTaskResponseBodyData Data { get; set; }
        public class DescribeEvaluateAndImportTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business ID of the import task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("Bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            /// <summary>
            /// <para>The summary information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;structureImportResult\&quot;:{\&quot;status\&quot;:\&quot;finish\&quot;,\&quot;finishedNum\&quot;:382,\&quot;totalNum\&quot;:382,\&quot;percentage\&quot;:100},\&quot;switchTips\&quot;:\&quot;正向同步延迟较小时才允许开始正向切换\&quot;,\&quot;autoTableSuggestionSwitch\&quot;:false,\&quot;structureAlterationMap\&quot;:{},\&quot;acceptFilterMap\&quot;:{\&quot;fr_import\&quot;:[\&quot;dy_dr_new\&quot;],\&quot;e3plus_drp_prod_new\&quot;:[],\&quot;qbtong_prod\&quot;:[],\&quot;e3plus_account_prod\&quot;:[],\&quot;e3plus_drp_prod\&quot;:[]},\&quot;structChunkMap\&quot;:{},\&quot;count\&quot;:1,\&quot;requestId\&quot;:\&quot;9380D025-C9B1-51D6-A4B9-733C4879CC4A\&quot;}&quot;,</para>
            /// </summary>
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            /// <summary>
            /// <para>The creator of the import task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>346650</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>Indicates whether the import task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            /// <summary>
            /// <para>The timestamp when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-08T15:00Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public long? GmtCreated { get; set; }

            /// <summary>
            /// <para>The modification time in timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605080537000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>76251</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the slink destination database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fr_import</para>
            /// </summary>
            [NameInMap("SlinkDstDb")]
            [Validation(Required=false)]
            public string SlinkDstDb { get; set; }

            /// <summary>
            /// <para>The instance ID of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-hzrehc60jz5zye</para>
            /// </summary>
            [NameInMap("SlinkDstResId")]
            [Validation(Required=false)]
            public string SlinkDstResId { get; set; }

            /// <summary>
            /// <para>The username for the data connection of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dts_dtdba</para>
            /// </summary>
            [NameInMap("SlinkDstUserName")]
            [Validation(Required=false)]
            public string SlinkDstUserName { get; set; }

            /// <summary>
            /// <para>The name of the slink source database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fr_import</para>
            /// </summary>
            [NameInMap("SlinkSrcDb")]
            [Validation(Required=false)]
            public string SlinkSrcDb { get; set; }

            /// <summary>
            /// <para>The instance ID of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drdshbga69378w4p</para>
            /// </summary>
            [NameInMap("SlinkSrcResId")]
            [Validation(Required=false)]
            public string SlinkSrcResId { get; set; }

            /// <summary>
            /// <para>The resource type of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POLARX1</para>
            /// </summary>
            [NameInMap("SlinkSrcResType")]
            [Validation(Required=false)]
            public string SlinkSrcResType { get; set; }

            /// <summary>
            /// <para>The username for the data connection of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtdba</para>
            /// </summary>
            [NameInMap("SlinkSrcUserName")]
            [Validation(Required=false)]
            public string SlinkSrcUserName { get; set; }

            /// <summary>
            /// <para>The stage of the synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_IMPORT_RUNNING</para>
            /// </summary>
            [NameInMap("SlinkStage")]
            [Validation(Required=false)]
            public string SlinkStage { get; set; }

            /// <summary>
            /// <para>The running status of the synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMPORT_RUNNING</para>
            /// </summary>
            [NameInMap("SlinkStatus")]
            [Validation(Required=false)]
            public string SlinkStatus { get; set; }

            /// <summary>
            /// <para>The description of the slink task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drdsprod_to_2.0</para>
            /// </summary>
            [NameInMap("SlinkTaskDesc")]
            [Validation(Required=false)]
            public string SlinkTaskDesc { get; set; }

            /// <summary>
            /// <para>The slink task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>etx-szr2rr6i*****</para>
            /// </summary>
            [NameInMap("SlinkTaskId")]
            [Validation(Required=false)]
            public string SlinkTaskId { get; set; }

            /// <summary>
            /// <para>The synchronization type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>evaluate_import</para>
            /// </summary>
            [NameInMap("SlinkType")]
            [Validation(Required=false)]
            public string SlinkType { get; set; }

        }

        /// <summary>
        /// <para>The response message. This parameter is empty when the request succeeds. If the request fails, an exception message is returned, such as an error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73559800-****-11ec-bd40-99cfcff3fe1e</para>
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
