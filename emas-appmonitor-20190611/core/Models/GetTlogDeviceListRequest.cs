// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class GetTlogDeviceListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24781204</para>
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
        /// <para>1778860800000</para>
        /// </summary>
        [NameInMap("BeginDate")]
        [Validation(Required=false)]
        public long? BeginDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>apple</para>
        /// </summary>
        [NameInMap("Brand")]
        [Validation(Required=false)]
        public string Brand { get; set; }

        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1633159200000</para>
        /// </summary>
        [NameInMap("CreateBeginDate")]
        [Validation(Required=false)]
        public long? CreateBeginDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1633159200000</para>
        /// </summary>
        [NameInMap("CreateEndDate")]
        [Validation(Required=false)]
        public long? CreateEndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1779465599999</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Z70g612312124323Hzn4X</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>iphone16</para>
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
        /// <para>1.0</para>
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
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1633159200000</para>
        /// </summary>
        [NameInMap("UpdateBeginDate")]
        [Validation(Required=false)]
        public long? UpdateBeginDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1633159200000</para>
        /// </summary>
        [NameInMap("UpdateEndDate")]
        [Validation(Required=false)]
        public long? UpdateEndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>userNick</para>
        /// </summary>
        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Z70g612312124323Hzn4X</para>
        /// </summary>
        [NameInMap("Utdid")]
        [Validation(Required=false)]
        public string Utdid { get; set; }

    }

}
