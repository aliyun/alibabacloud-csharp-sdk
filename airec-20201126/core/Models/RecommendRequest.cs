// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class RecommendRequest : TeaModel {
        /// <summary>
        /// <para>The status of the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJqb2luIjoiYW5kIiwiZmlsdGVycyI6W3siY29uZCI6ImNvbnRhaW4iLCJmaWVsZCI6InRhZ3MiLCJ2YWx1ZSI6IuWPjOS6uiJ9XX0.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The ID of the scene in which the item is to be recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06e1565409c9fc4887036b974421****</para>
        /// </summary>
        [NameInMap("imei")]
        [Validation(Required=false)]
        public string Imei { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.1</para>
        /// </summary>
        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The information about event tracking. The value of this parameter varies based on different items and needs to be uploaded together with the corresponding behavior data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public string Items { get; set; }

        /// <summary>
        /// <para>N/A</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("rankOpen")]
        [Validation(Required=false)]
        public bool? RankOpen { get; set; }

        /// <summary>
        /// <para>The type of the recommended item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gul</para>
        /// </summary>
        [NameInMap("recType")]
        [Validation(Required=false)]
        public string RecType { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("returnCount")]
        [Validation(Required=false)]
        public int? ReturnCount { get; set; }

        /// <summary>
        /// <para>The number of result entries to return. Valid values: 0 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("sceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The position at which the recommended item is displayed. The position number starts from 0. The return results are ranked by position. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>如果需要使用坑位策略，请求参数内新增strategy=&quot;fixedSlot&quot;，此时系统将按照坑位配置返回推荐结果</para>
        /// 
        /// <b>Example:</b>
        /// <para>fixedSlot</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <para>The items used for related recommendations in specified scenes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("userInfo")]
        [Validation(Required=false)]
        public string UserInfo { get; set; }

    }

}
