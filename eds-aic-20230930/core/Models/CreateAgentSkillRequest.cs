// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateAgentSkillRequest : TeaModel {
        /// <summary>
        /// <para>The list of files in the skill package.</para>
        /// </summary>
        [NameInMap("FileList")]
        [Validation(Required=false)]
        public List<string> FileList { get; set; }

        /// <summary>
        /// <para>The icon of the custom skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>icon01</para>
        /// </summary>
        [NameInMap("IconKey")]
        [Validation(Required=false)]
        public string IconKey { get; set; }

        /// <summary>
        /// <para>The OSS path of the skill package. This parameter is reserved by the system and does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test/sk-test/current/skill.zip</para>
        /// </summary>
        [NameInMap("PackageOssKey")]
        [Validation(Required=false)]
        public string PackageOssKey { get; set; }

        /// <summary>
        /// <para>The skill description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Current weather and forecasts with wttr.in via curl for locations, rain, temperature, travel planning.</para>
        /// </summary>
        [NameInMap("SkillDescription")]
        [Validation(Required=false)]
        public string SkillDescription { get; set; }

        /// <summary>
        /// <para>The skill name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weather-enhanced</para>
        /// </summary>
        [NameInMap("SkillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>The OSS download URL of the skill package. This parameter is required for API calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://test.oss-cn-hangzhou.aliyuncs.com/weather_skill.zip?Expires=1788168088&OSSAccessKeyId=">https://test.oss-cn-hangzhou.aliyuncs.com/weather_skill.zip?Expires=1788168088&amp;OSSAccessKeyId=</a>****</para>
        /// </summary>
        [NameInMap("SkillPackageUrl")]
        [Validation(Required=false)]
        public string SkillPackageUrl { get; set; }

    }

}
