// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emas_appmonitor20190611.Models
{
    public class CreateTlogTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20000000</para>
        /// </summary>
        [NameInMap("AliYunCurrentPk")]
        [Validation(Required=false)]
        public string AliYunCurrentPk { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20000000</para>
        /// </summary>
        [NameInMap("AliYunMainPk")]
        [Validation(Required=false)]
        public string AliYunMainPk { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emas_user</para>
        /// </summary>
        [NameInMap("AliYunName")]
        [Validation(Required=false)]
        public string AliYunName { get; set; }

        /// <summary>
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
        /// <para>1.0.0</para>
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
        /// <para>Redmi</para>
        /// </summary>
        [NameInMap("Brand")]
        [Validation(Required=false)]
        public string Brand { get; set; }

        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>temp</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CollectionNums")]
        [Validation(Required=false)]
        public long? CollectionNums { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public string Days { get; set; }

        [NameInMap("DeviceJson")]
        [Validation(Required=false)]
        public string DeviceJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1779465599999</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>temp</para>
        /// </summary>
        [NameInMap("ErrorType")]
        [Validation(Required=false)]
        public string ErrorType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>iPhone16</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;First&quot;:true,&quot;Completed&quot;:true,&quot;NotifyPhone&quot;:true,&quot;NotifyEmail&quot;:true,&quot;NotifyWebhook&quot;:true,&quot;ContactGroupIds&quot;:[1]}</para>
        /// </summary>
        [NameInMap("NotifySettingJson")]
        [Validation(Required=false)]
        public string NotifySettingJson { get; set; }

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
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("OsVersion")]
        [Validation(Required=false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
