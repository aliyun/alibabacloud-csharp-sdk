// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class GetTlogCollectListRequest : TeaModel {
        /// <summary>
        /// <para>appKey</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24780725</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1777996800000</para>
        /// </summary>
        [NameInMap("BeginDate")]
        [Validation(Required=false)]
        public long? BeginDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hangzhou</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1777996800000</para>
        /// </summary>
        [NameInMap("CreateBeginDate")]
        [Validation(Required=false)]
        public long? CreateBeginDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1777996800000</para>
        /// </summary>
        [NameInMap("CreateEndDate")]
        [Validation(Required=false)]
        public long? CreateEndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ad-0002nzx5r86f7jzrv0nx-91</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1777996800000</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user_nick</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>iphone</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OsVersion")]
        [Validation(Required=false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>positiveComment</para>
        /// </summary>
        [NameInMap("PositiveComment")]
        [Validation(Required=false)]
        public string PositiveComment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>START</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1777996800000</para>
        /// </summary>
        [NameInMap("UpdateBeginDate")]
        [Validation(Required=false)]
        public long? UpdateBeginDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1777996800000</para>
        /// </summary>
        [NameInMap("UpdateEndDate")]
        [Validation(Required=false)]
        public long? UpdateEndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user_nick</para>
        /// </summary>
        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Z70g6V/MXJ8DABtD53eHzn4X</para>
        /// </summary>
        [NameInMap("Utdid")]
        [Validation(Required=false)]
        public string Utdid { get; set; }

    }

}
