// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsRegionListResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsRegionListResponseBodyData Data { get; set; }
        public class OnsRegionListResponseBodyData : TeaModel {
            [NameInMap("RegionDo")]
            [Validation(Required=false)]
            public List<OnsRegionListResponseBodyDataRegionDo> RegionDo { get; set; }
            public class OnsRegionListResponseBodyDataRegionDo : TeaModel {
                /// <summary>
                /// <para>The channel name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN</para>
                /// </summary>
                [NameInMap("ChannelName")]
                [Validation(Required=false)]
                public string ChannelName { get; set; }

                /// <summary>
                /// <para>The time when the instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1411623866000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
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
                [NameInMap("OnsRegionId")]
                [Validation(Required=false)]
                public string OnsRegionId { get; set; }

                /// <summary>
                /// <para>The region name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China (Hangzhou)</para>
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// <para>The time when the instance was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1411623866000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72D14A84-45E5-4E01-A6DB-F63C4721****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
