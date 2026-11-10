// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeDataAgentSkillDownloadResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataAgentSkillDownloadResponseBodyData Data { get; set; }
        public class DescribeDataAgentSkillDownloadResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The public download link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://<em><b><b><b>.oss-cn-hangzhou.aliyuncs.com/data_agent/skill_download/1673826</b></b></b>66/ski-1giw1afhxxl6**<b><b><b>ygcir/</b></b></b></em>.zip?Expires=1793935883&amp;OSSAccessKeyId=STS.NXy5M8bN5wuNt*******NxDW&amp;Signature=%2FrU3FTVCAdtJJvZQvrftw6AWQug%3D&amp;response-content-disposition=attachment&amp;security-token=CAISiQR1q6Ft5B2yfSjIr5vMfveMj5EUwLeldmzA1lA6ZLlBob3vtTz2IHhMdXlrCOgYt%2F8xnG1V6f8flrJ%2FToQAX0HfatZq5ZkS9AqnaoXM%2Fte496IFg5D9pf1flOynjqHoeOzcYI734p7PAgm2FEYRrJL%2BcTK9JRPHVbSClZ9gaPkOQwC8dkAoLdxKJwxk2qh4UHzKLqSCPwLNiGjdB1YSZWMe71ly8qOi2MaRxwPDhVnhsI8vqp%2F2P4KvYrueVfWAOt6%2Bx75xbbGTknwSuRRP7%2BJ6hbBNvD7Is9eBRlJXpg6GOuzb8tRuawNweqENEqFJquS7jv55vujkm4PozRJKNO0SCnqAH9D6npWZQLr0bI9nK%2FHgOHWIi9%2BOKcD8vQM0cXZFKwRYKtQ8LWBhBhctUHbKMqPi9lTNfUK%2FQrOGlagt0pZ801zfpIXbfAnUGe%2FJi3dBY9kublsKT0dOhTG5K%2FJfLlEcKAg5WeevIN8tPEwEm8TBphbPUyBs9HZTssDlaune0qJlMt2nD8IdgNJDPc8Y6zZ3EA2qUcGnjkYFaWppRK1Oyq7mNISk6bmKzOyPaPTBDv0Xb%2BrupowlAUBnIFEnzk2ZjrVLATLwcBQLRCBzwt1KpKo%2FNH0u7BAEADeclSYSR4GYQXr9nsHtPA6ksAQWlPeWMacBiy9GOsPAqYv0GlbRDSX9P8FR8BqAARLcIr26y%2BphYuiqaegPh83GYEiMKKQS66fO%2FbR98Z9kD2BZrL%2FN3hztB48fQZyNeNE9AMmLzxuyk%2BHfEozrUOP7nvr%2F73NxdW5ydDWgil66VEwx5Grjy43Q3OZPIPUrn7t4WFMWd8oxvqgo47IApLHY3G5akK6pzYHmVrskTrtjIAA%3D</para>
            /// </summary>
            [NameInMap("DownloadLink")]
            [Validation(Required=false)]
            public string DownloadLink { get; set; }

            /// <summary>
            /// <para>The internal network download link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://<em><b><b><b>.oss-cn-hangzhou-internal.aliyuncs.com/data_agent/skill_download/1673826</b></b></b>66/ski-1giw1afhxxl6**<b><b><b>ygcir/</b></b></b></em>.zip?Expires=1793935883&amp;OSSAccessKeyId=STS.NXy5M8bN5wuNt*******NxDW&amp;Signature=%2FrU3FTVCAdtJJvZQvrftw6AWQug%3D&amp;response-content-disposition=attachment&amp;security-token=CAISiQR1q6Ft5B2yfSjIr5vMfveMj5EUwLeldmzA1lA6ZLlBob3vtTz2IHhMdXlrCOgYt%2F8xnG1V6f8flrJ%2FToQAX0HfatZq5ZkS9AqnaoXM%2Fte496IFg5D9pf1flOynjqHoeOzcYI734p7PAgm2FEYRrJL%2BcTK9JRPHVbSClZ9gaPkOQwC8dkAoLdxKJwxk2qh4UHzKLqSCPwLNiGjdB1YSZWMe71ly8qOi2MaRxwPDhVnhsI8vqp%2F2P4KvYrueVfWAOt6%2Bx75xbbGTknwSuRRP7%2BJ6hbBNvD7Is9eBRlJXpg6GOuzb8tRuawNweqENEqFJquS7jv55vujkm4PozRJKNO0SCnqAH9D6npWZQLr0bI9nK%2FHgOHWIi9%2BOKcD8vQM0cXZFKwRYKtQ8LWBhBhctUHbKMqPi9lTNfUK%2FQrOGlagt0pZ801zfpIXbfAnUGe%2FJi3dBY9kublsKT0dOhTG5K%2FJfLlEcKAg5WeevIN8tPEwEm8TBphbPUyBs9HZTssDlaune0qJlMt2nD8IdgNJDPc8Y6zZ3EA2qUcGnjkYFaWppRK1Oyq7mNISk6bmKzOyPaPTBDv0Xb%2BrupowlAUBnIFEnzk2ZjrVLATLwcBQLRCBzwt1KpKo%2FNH0u7BAEADeclSYSR4GYQXr9nsHtPA6ksAQWlPeWMacBiy9GOsPAqYv0GlbRDSX9P8FR8BqAARLcIr26y%2BphYuiqaegPh83GYEiMKKQS66fO%2FbR98Z9kD2BZrL%2FN3hztB48fQZyNeNE9AMmLzxuyk%2BHfEozrUOP7nvr%2F73NxdW5ydDWgil66VEwx5Grjy43Q3OZPIPUrn7t4WFMWd8oxvqgo47IApLHY3G5akK6pzYHmVrskTrtjIAA%3D</para>
            /// </summary>
            [NameInMap("IntranetDownloadLink")]
            [Validation(Required=false)]
            public string IntranetDownloadLink { get; set; }

            /// <summary>
            /// <para>The skill ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ski-04pomiln*************j0</para>
            /// </summary>
            [NameInMap("SkillId")]
            [Validation(Required=false)]
            public string SkillId { get; set; }

            /// <summary>
            /// <para>The skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data-query-skill</para>
            /// </summary>
            [NameInMap("SkillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when a request exception occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidTid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D21075-CD3E-4D98-8264-FD8AD04A63B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
