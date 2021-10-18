// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliyunape20210908.Models
{
    public class HistoricalRequest : TeaModel {
        /// <summary>
        /// UserId
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// 用户中心--我的订单--订单请求--实例名称：aliyunape_meteor12_public_cn-0ju2d2hh90b
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// station全国（入参单一站点）
        /// </summary>
        [NameInMap("Station")]
        [Validation(Required=false)]
        public string Station { get; set; }

        /// <summary>
        /// pageSize是	页面条数
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// startTimeyyyymmddhh0000（当startTime为空时无数据产出，确认是否入参）
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// endTimeyyyymmddhh0000 （当endTime为空时无数据产出，确认是否入参）
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// pageNum页码数
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

    }

}
