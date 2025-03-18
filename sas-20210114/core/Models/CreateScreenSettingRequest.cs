// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20210114.Models
{
    public class CreateScreenSettingRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LogoPower")]
        [Validation(Required=false)]
        public bool? LogoPower { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/tfs/xxxx.png">https://img.alicdn.com/tfs/xxxx.png</a></para>
        /// </summary>
        [NameInMap("LogoUrl")]
        [Validation(Required=false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://monitor.xxxxxxx">https://monitor.xxxxxxx</a></para>
        /// </summary>
        [NameInMap("MonitorUrl")]
        [Validation(Required=false)]
        public string MonitorUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;positionId&quot;:1,&quot;componentId&quot;:3,&quot;date&quot;:&quot;7-day&quot;},{&quot;positionId&quot;:2,&quot;componentId&quot;:1,&quot;date&quot;:&quot;0-second&quot;},{&quot;positionId&quot;:3,&quot;componentId&quot;:8,&quot;date&quot;:&quot;15-day&quot;},{&quot;positionId&quot;:4,&quot;componentId&quot;:11,&quot;date&quot;:&quot;15-day&quot;},{&quot;positionId&quot;:5,&quot;componentId&quot;:23,&quot;date&quot;:&quot;24-hour&quot;},{&quot;positionId&quot;:6,&quot;componentId&quot;:17,&quot;date&quot;:&quot;24-hour&quot;},{&quot;positionId&quot;:7,&quot;componentId&quot;:13,&quot;date&quot;:&quot;24-hour&quot;},{&quot;positionId&quot;:8,&quot;componentId&quot;:25,&quot;date&quot;:&quot;0-second&quot;}]</para>
        /// </summary>
        [NameInMap("ScreenDataMap")]
        [Validation(Required=false)]
        public string ScreenDataMap { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ScreenDefault")]
        [Validation(Required=false)]
        public int? ScreenDefault { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
