// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListRLTrajectoriesRequest : TeaModel {
        /// <summary>
        /// <para>查询窗口截止时间，采用 RFC3339 格式。未提供时使用服务端当前 UTC 时间，并向下对齐到 30 秒边界。为容纳日志采集延迟，实际读取的采集时间上界在该值基础上延后 5 分钟，并非严格按事件发生时间过滤。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-07T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>页码（从 1 开始，最大 1000000）；与 PageSize 必须同时提供，均不传则按默认分页 PageNumber=1、PageSize=10 返回</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>每页条数（最大 1000）；与 PageNumber 必须同时提供，均不传则默认 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>样本 uid</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3afcfbdf-3956-4ab2-b9cb-f9c204b8fc9c</para>
        /// </summary>
        [NameInMap("PromptUid")]
        [Validation(Required=false)]
        public string PromptUid { get; set; }

        /// <summary>
        /// <para>查询窗口起始时间，采用 RFC3339 格式。未提供时默认为 EndTime 前 7 天；必须早于 EndTime，时间跨度不得超过 30 天。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-04T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
